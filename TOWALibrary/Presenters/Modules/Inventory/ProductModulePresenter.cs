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
using TOWALibrary.Services.CommonServices;
using TOWALibrary.Services.ModelServices.ProductServices;
using TOWALibrary.Services.ModelServices.SupplierServices;
using TOWALibrary.Views.ModuleViews.Inventory;

namespace TOWALibrary.Presenters.Modules.Inventory.Products
{
    public class ProductModulePresenter
    {
        

        #region Services
        private readonly IProductModelServices _productModelServices = ServicesManager.ProductModelServices;
        private readonly ICategoryModelServices _categoryModelServices = ServicesManager.CategoryModelServices;
        private readonly ISupplierModelServices _supplierModelServices = ServicesManager.SupplierModelServices;

        #endregion

        #region BindingSource
        private BindingSource _productBindingSource;
        private BindingSource _categoryBindingSource;
        private BindingSource _supplierBindingSource;
        private BindingSource _categoryNameBindingSource;
        private BindingSource _supplierNameBiningSource;
        #endregion

        #region Contructor
        private readonly IProductModuleView _view;
        public ProductModulePresenter(IProductModuleView view)
        {
            _view = view;
            //Intailize all binding source
            _productBindingSource = new BindingSource();
            _categoryBindingSource = new BindingSource();
            _supplierBindingSource = new BindingSource();
            // Filter sources
            _supplierNameBiningSource = new BindingSource();
            _categoryNameBindingSource = new BindingSource();
            //Wire up event handler methods to view events
            _view.SearchEvent += SearchProduct;
            _view.AddNewEvent += AddNewProduct;
            _view.EditEvent += LoadSelectedProductToEdit;
            _view.DeleteEvent += DeleteSelectedProduct;
            _view.SaveEvent += SaveProduct;
            _view.CancelEvent += CancelAction;

            //Set binding source
            //Set binding source for filter
            LoadAllList();
   

        }
        #endregion


        private void LoadAllList()
        {
            LoadCategoryList();
            LoadSupplierList();  
            // Load product list
            var productList = _productModelServices.GetAll().ToList();
            _productBindingSource.DataSource = productList;
            _view.SetListViewBindingSource(_productBindingSource);

        }

        private void LoadSupplierList()
        {
            // Module
            _supplierBindingSource.DataSource = _supplierModelServices.GetAll().Select(c => new { ID = c.SLID, Name = c.SupplierName }); ;
            _view.SetSupplierList(_supplierBindingSource);
            // Filter
            var supplierNameList = _supplierModelServices.GetAll().Select(p => new { ID = p.SLID, Name = p.SupplierName }).ToList();
            supplierNameList.Insert(0, new { ID = "SL0", Name = "All" });
            _supplierNameBiningSource.DataSource = supplierNameList;
            _view.SetSupplierNameListBindingSource(_supplierNameBiningSource);
        }

        private void LoadCategoryList()
        {
            // Module
            _categoryBindingSource.DataSource = _categoryModelServices.GetAll().Select(c => new { ID = c.CATEID, Name = c.CategoryName });
            _view.SetCategoryList(_categoryBindingSource);
            // Filter
            var categoryList = _categoryModelServices.GetAll().Select(p => new { ID = p.CATEID, Name = p.CategoryName }).ToList();
            categoryList.Insert(0, new { ID = 0, Name = "All" });
            _categoryNameBindingSource.DataSource = categoryList;
            _view.SetCategoryNameListBindingSource(_categoryNameBindingSource);

        }

        private void LoadSelectedProductToEdit(object sender, EventArgs e)
        {
            ProductModel model = (ProductModel)_productBindingSource.Current;
            // Product Info
            _view.PID = model.PID;
            _view.ProductName = model.ProductName;
            _view.Barcode = model.Barcode;
            // Stock Info
            _view.QuantityPerUnit = model.QuantityPerUnit;
            _view.UnitOnOrder = model.UnitOnOrder;
            _view.UnitOnStock = model.UnitOnStock;
            // Sale info
            _view.UnitPrice = Convert.ToDouble(model.UnitPrice);
            _view.SalesPrice = Convert.ToDouble(model.SalesPrice);
            _view.Status = model.Status;
            _view.VAT = Convert.ToDouble(model.VAT);
            // Details 
            _view.SelectedSLID = model.Supplier.SLID;
            _view.SelectedCID = model.Category.CATEID;
            _view.Content = model.Content;
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
                Supplier = _supplierModelServices.GetByValue(_view.SelectedSLID.Trim()).FirstOrDefault(),

                Category = _categoryModelServices.GetByValue( _view.SelectedCID.ToString() ).FirstOrDefault()
            };
            try
            {
                _productModelServices.ValidateModel(model);
                if (_view.IsEdit == true)
                {
                    _productModelServices.Update(model);
                    _view.Message = "Product updated successfully!";
                }
                else
                {
                    _productModelServices.Add(model);
                    _view.Message = "Product added successfully!";
                }
                _view.IsSuccessful = true;
                Refresh();
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
                var model = (ProductModel)_productBindingSource.Current;
                _productModelServices.Delete(model.PID.ToString());
                _view.IsSuccessful = true;
                _view.Message = "Product deleted successfully";
                Refresh();
            }
            catch (Exception)
            {
                _view.IsSuccessful = false;
                _view.Message = "An error occurred, could not delete this product";
            }
        }

        private void AddNewProduct(object sender, EventArgs e)
        {
            _view.IsEdit = false;
        }

        private void SearchProduct(object sender, EventArgs e)
        {
            var SearchValue = "";
            if (_view.IsValueSearch)
                SearchValue = _view.SearchValue;

            var CID = Convert.ToInt32(_view.SelectedCIDName);
            var SLID = _view.SelectedSLIDName;
            var productList = _productModelServices.GetByValue(SearchValue)
                .Where(p => CID == 0 || (p.Category.CATEID == CID))
                .Where(p => SLID.Equals("SL0") || SLID.Equals(p.Supplier.SLID)).ToList();

            _productBindingSource.DataSource = productList;
            _view.IsValueSearch = false;
        }

        private void Refresh()
        {
            _view.SelectedSLIDName = "SL0";
            _view.SelectedCIDName = 0;
            _productBindingSource.DataSource = _productModelServices.GetAll().ToList();
        }

        private void CleanViewFeilds()
        {
            // Product Info
            _view.PID = "P0";
            _view.ProductName = "";
            _view.Barcode = "";
            // Stock Info
            _view.QuantityPerUnit = "";
            _view.UnitOnOrder = 0;
            _view.UnitOnStock = 0;
            // Sale info
            _view.UnitPrice = 0;
            _view.SalesPrice = 0;
            _view.VAT = 0;
            // Details 
            _view.Content = "";
            _view.Status = "On Hand";
            
        }
    }
}
