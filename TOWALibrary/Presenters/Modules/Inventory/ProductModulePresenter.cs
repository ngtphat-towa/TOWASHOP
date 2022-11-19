using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Models.Contact.Suppliers;
using TOWALibrary.Models.Inventory.Categoires;
using TOWALibrary.Models.Inventory.Products;
using TOWALibrary.Repositories.Inventory.Products;
using TOWALibrary.Services.CategoryServices;
using TOWALibrary.Services.ModelServices.ProductServices;
using TOWALibrary.Services.ModelServices.SupplierServices;
using TOWALibrary.Views.ModuleViews.Inventory;

namespace TOWALibrary.Presenters.Modules.Inventory.Products
{
    public class ProductModulePresenter
    {
        private readonly IProductModuleView _view;
        private readonly IProductModelServices _productServices;
        private readonly ICategoryModelServices _categoryServices;
        private readonly ISupplierModelServices _supplierServices;

        private BindingSource productBindingSource;
        private BindingSource categoryBindingSource;
        private BindingSource supplierBiningSource;

    
        public ProductModulePresenter(IProductModuleView view, IProductModelServices productServices, ICategoryModelServices categoryServices, ISupplierModelServices supplierServices)
        {
            this._view = view;
            this._productServices = productServices;
            this._categoryServices = categoryServices;
            this._supplierServices = supplierServices;
            //Intailize all binding source
            this.productBindingSource = new BindingSource();
            this.categoryBindingSource = new BindingSource();
            this.supplierBiningSource = new BindingSource();
            //Wire up event handler methods to view events
            this._view.SearchEvent += SearchProduct;
            this._view.AddNewEvent += AddNewProduct;
            this._view.EditEvent += LoadSelectedProductToEdit;
            this._view.DeleteEvent += DeleteSelectedProduct;
            this._view.SaveEvent += SaveProduct;
            this._view.CancelEvent += CancelAction;
            //Set binding source
            this._view.SetListViewBindingSource(productBindingSource);
            LoadAllProdcutList();
            LoadAllCategories();
            LoadAllSuppliers();
            
            //Show view
            this._view.Show();
        }

        private void LoadSelectedProductToEdit(object sender, EventArgs e)
        {
            ProductModel model = (ProductModel)productBindingSource.Current;
            // Product Info
            this._view.PID = model.PID;
            this._view.ProductName = model.ProductName;
            this._view.Barcode = model.Barcode;
            // Stock Info
            this._view.QuantityPerUnit = model.QuantityPerUnit;
            this._view.UnitOnOrder = model.UnitOnOrder;
            this._view.UnitOnStock = model.UnitOnStock;
            // Sale info
            this._view.UnitPrice = Convert.ToDouble(model.UnitPrice);
            this._view.SalesPrice = Convert.ToDouble(model.SalesPrice);
            this._view.Status = model.Status;
            this._view.VAT = Convert.ToDouble(model.VAT);
            // Details 
            this._view.SelectedSLID = model.Supplier.SLID;
            this._view.SelectedCID = model.Category.CATEID;
            this._view.Content = model.Content;
            _view.IsEdit = true;

        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFeilds();
        }

        private void SaveProduct(object sender, EventArgs e)
        {

            var model = new ProductModel
            {
                PID = _view.PID,
                ProductName = _view.ProductName,
                Barcode = _view.Barcode,
                QuantityPerUnit = _view.QuantityPerUnit,
                UnitOnStock = _view.UnitOnStock,
                UnitOnOrder = _view.UnitOnOrder,
                UnitPrice = (double)_view.UnitPrice,
                SalesPrice = (double)_view.SalesPrice,
                Status = _view.Status,
                Supplier = _supplierServices.GetByValue(_view.SelectedSLID.Trim()).FirstOrDefault(),

                Category = _categoryServices.GetByValue( _view.SelectedCID.ToString() ).FirstOrDefault()
            };
            try
            {
                _productServices.ValidateModel(model);
                if (_view.IsEdit == true)
                {
                    _productServices.Update(model);
                    _view.Message = "Product updated successfully!";
                }
                else
                {
                    _productServices.Add(model);
                    _view.Message = "Product added successfully!";
                }
                _view.IsSuccessful = true;
                LoadAllProdcutList();
                CleanViewFeilds();

            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        private void DeleteSelectedProduct(object sender, EventArgs e)
        {
            try
            {
                var model = (ProductModel)productBindingSource.Current;
                _productServices.Delete(model.PID.ToString());
                _view.IsSuccessful = true;
                _view.Message = "Product deleted successfully";
                LoadAllProdcutList();
            }
            catch (Exception)
            {
                _view.IsSuccessful = false;
                _view.Message = "An error occurred, could not delete this product";
            }
        }

        private void AddNewProduct(object sender, EventArgs e)
        {
            this._view.IsEdit = false;
        }

        private void SearchProduct(object sender, EventArgs e)
        {
            productBindingSource.DataSource = null;
            productBindingSource.DataSource = _productServices.GetByValue(this._view.SearchValue);            
        }

        private void LoadAllProdcutList()
        {
            productBindingSource.DataSource = null;
            productBindingSource.DataSource = _productServices.GetAll();
        }
        private void LoadAllCategories()
        {
            categoryBindingSource.DataSource = _categoryServices.GetAll().Select(c => new { ID = c.CATEID, Name = c.CategoryName });
            this._view.SetCategoryList(categoryBindingSource);
        }
        private void LoadAllSuppliers()
        {
            supplierBiningSource.DataSource = _supplierServices.GetAll().Select(c => new { ID = c.SLID, Name = c.SupplierName }); ;
            this._view.SetSupplierList(supplierBiningSource);
        }
        private void CleanViewFeilds()
        {
            // Product Info
            this._view.PID = "P0";
            this._view.ProductName = "";
            this._view.Barcode = "";
            // Stock Info
            this._view.QuantityPerUnit = "";
            this._view.UnitOnOrder = 0;
            this._view.UnitOnStock = 0;
            // Sale info
            this._view.UnitPrice = 0;
            this._view.SalesPrice = 0;
            this._view.VAT = 0;
            // Details 
            LoadAllCategories();
            this._view.SetSupplierList(supplierBiningSource);
            LoadAllSuppliers();
            this._view.SetCategoryList(categoryBindingSource);
            this._view.Content = "";
            this._view.Status = "On Hand";
            
        }
    }
}
