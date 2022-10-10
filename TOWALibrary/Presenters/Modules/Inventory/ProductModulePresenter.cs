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
using TOWALibrary.Views.ModuleViews.Inventory;

namespace TOWALibrary.Presenters.Modules.Inventory.Products
{
    public class ProductModulePresenter
    {
        private readonly IProductModuleView view;
        private readonly IProductRepository repository;
        private BindingSource bindingSource;
        private ICollection<ProductModel> productList;
        private ICollection<SupplierModel> supplierList;
        private ICollection<CategoryModel> categoryList;
        public ProductModulePresenter(IProductModuleView view, IProductRepository repository)
        {
            this.view = view;
            this.repository = repository;
            this.bindingSource = new BindingSource();
            //Wire up event handler methods to view events
            this.view.SearchEvent += SearchProduct;
            this.view.AddNewEvent += AddNewProduct;
            this.view.EditEvent += LoadSelectedProductToEdit;
            this.view.DeleteEvent += DeleteSelectedProduct;
            this.view.SaveEvent += SaveProduct;
            this.view.CancelEvent += CancelAction;
            //Set binding source
            this.view.SetListViewBindingSource(bindingSource);
            LoadAllProdcutList();
            LoadAllCategories();
            LoadAllSuppliers();
            
            //Show view
            this.view.Show();
        }

        private void LoadSelectedProductToEdit(object sender, EventArgs e)
        {
            ProductModel model = (ProductModel)bindingSource.Current;
            // Product Info
            this.view.PID = model.PID;
            this.view.ProductName = model.ProductName;
            this.view.Barcode = model.Barcode;
            // Stock Info
            this.view.QuantityPerUnit = model.QuantityPerUnit;
            this.view.UnitOnOrder = model.UnitOnOrder;
            this.view.UnitOnStock = model.UnitOnStock;
            // Sale info
            this.view.UnitPrice = Convert.ToDecimal(model.UnitPrice);
            this.view.SalesPrice = Convert.ToDecimal(model.SalesPrice);
            this.view.Status = model.Status;
            this.view.VAT = Convert.ToDecimal(model.VAT);
            // Details 
            this.view.SelectedSLID = model.Supplier.SLID;
            this.view.SelectedCID = model.Category.CATEID;
            this.view.Content = model.Content;
            view.IsEdit = true;

        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFeilds();
        }

        private void SaveProduct(object sender, EventArgs e)
        {

            var model = new ProductModel
            {
                PID = view.PID,
                ProductName = view.ProductName,
                Barcode = view.Barcode,
                QuantityPerUnit = view.QuantityPerUnit,
                UnitOnStock = view.UnitOnStock,
                UnitOnOrder = view.UnitOnOrder,
                UnitPrice = (double)view.UnitPrice,
                SalesPrice = (double)view.SalesPrice,
                Status = view.Status,
                Supplier = supplierList.Where(x=> x.SLID.Equals(view.SelectedSLID)).FirstOrDefault(),
                Category = categoryList.Where(x=> x.CATEID==view.SelectedCID).FirstOrDefault()
            };
            try
            {
                // TODO - Vailidate the model 
                if (view.IsEdit == true)
                {
                    repository.Update(model);
                    view.Message = "Product updated successfully!";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Product added successfully!";
                }
                view.IsSuccessful = true;
                LoadAllProdcutList();
                CleanViewFeilds();

            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void DeleteSelectedProduct(object sender, EventArgs e)
        {
            try
            {
                var model = (ProductModel)bindingSource.Current;
                repository.Delete(model.PID.ToString());
                view.IsSuccessful = true;
                view.Message = "Product deleted successfully";
                LoadAllProdcutList();
            }
            catch (Exception)
            {
                view.IsSuccessful = false;
                view.Message = "An error occurred, could not delete this product";
            }
        }

        private void AddNewProduct(object sender, EventArgs e)
        {
            this.view.IsEdit = false;
        }

        private void SearchProduct(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(this.view.SearchValue);
            if (emptyValue == false)
                productList = repository.GetByValue(this.view.SearchValue);
            else
                productList = repository.GetAll();
            bindingSource.DataSource = productList;
        }

        private void LoadAllProdcutList()
        {
            productList=repository.GetAll();
            bindingSource.DataSource = productList;
        }
        private void LoadAllCategories()
        {
            categoryList = repository.GetCategories();
            this.view.SetCategoryList(categoryList);
        }
        private void LoadAllSuppliers()
        {
            supplierList = repository.GetSupliers();
            this.view.SetSupplierList(supplierList);
        }
        private void CleanViewFeilds()
        {
            // Product Info
            this.view.PID = "P0";
            this.view.ProductName = "";
            this.view.Barcode = "";
            // Stock Info
            this.view.QuantityPerUnit = "";
            this.view.UnitOnOrder = 0;
            this.view.UnitOnStock = 0;
            // Sale info
            this.view.UnitPrice = 0;
            this.view.SalesPrice = 0;
            this.view.VAT = 0;
            // Details 
            LoadAllCategories();
            this.view.SetSupplierList(supplierList);
            LoadAllSuppliers();
            this.view.SetCategoryList(categoryList);
            this.view.Content = "";
            this.view.Status = "On Hand";
            
        }
    }
}
