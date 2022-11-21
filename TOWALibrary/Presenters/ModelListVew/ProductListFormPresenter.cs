using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Models.Inventory.Products;
using TOWALibrary.Repositories;
using TOWALibrary.Repositories.Contacts.Suppliers;
using TOWALibrary.Repositories.Inventory.Categories;
using TOWALibrary.Repositories.Inventory.Products;
using TOWALibrary.Services.CategoryServices;
using TOWALibrary.Services.ModelServices.ProductServices;
using TOWALibrary.Services.ModelServices.SupplierServices;
using TOWALibrary.Views.ModelListVew;

namespace TOWALibrary.Presenters.ModelListVew
{
   public class ProductListFormPresenter
    {
        private readonly IProductListView _view;
        private readonly ISupplierModelServices _supplierModelServices ;
        private readonly ICategoryModelServices _categoryModelServices ;
        private readonly IProductModelServices _productModelServices ;

        private readonly BindingSource _categoryBindingSource;
        private readonly BindingSource _suplierBindingSource;
        private readonly BindingSource _productBindingSource;
        public ProductListFormPresenter(IProductListView view, IProductModelServices productModelServices, ISupplierModelServices supplierModelServices, ICategoryModelServices categoryModelServices  )
        {
            _view = view;
            _productModelServices = productModelServices;
            _categoryModelServices = categoryModelServices;
            _supplierModelServices = supplierModelServices;
            // Wireup combobox
            _categoryBindingSource = new BindingSource();
            _suplierBindingSource = new BindingSource();
            _productBindingSource = new BindingSource();
            // Wire up event 
            _view.AddProductEvent += AddProductEvent;
            _view.CancelAddEvent += CancelAddEvent;
            _view.SearchFilterChangedEvent += SearchFilterChangedEvent;

            LoadAllList();
            _view.SetSupplierNameListBindingSource(_suplierBindingSource);
            _view.SetCategoryListBindlingSource(_categoryBindingSource);
            _view.SetProductListBindingSource(_productBindingSource);
        }



        private void SearchFilterChangedEvent(object sender, EventArgs e)
        {
            var SearchValue = "";
            if(_view.IsValueSearch)
                SearchValue = _view.SearchValue;
            
            var productList = _productModelServices.GetByValue(SearchValue)
                .Where(p => _view.CTID == 0 ||  (p.Category.CATEID  == _view.CTID))
                .Where(p=> _view.SLID.Equals("SL0") || _view.SLID.Equals(p.Supplier.SLID)).ToList();
            
            _productBindingSource.DataSource = productList;
            _view.IsValueSearch = false;
        }

        private void LoadAllList()
        {
            // Load supplier list
            var supplierNameList = _supplierModelServices.GetAll().Select(p => new { ID = p.SLID, Name = p.SupplierName }).ToList();
            supplierNameList.Insert(0, new { ID = "SL0", Name = "All" });
            _suplierBindingSource.DataSource = supplierNameList;
            // Load category list
            var categoryList = _categoryModelServices.GetAll().Select(p => new { ID = p.CATEID, Name = p.CategoryName }).ToList();
            categoryList.Insert(0, new { ID = 0, Name = "All" });
            _categoryBindingSource.DataSource = categoryList;
            // Load product list
            var productList = _productModelServices.GetAll().ToList();
            _productBindingSource.DataSource = productList;
        }

        private void CancelAddEvent(object sender, EventArgs e)
        {
            _view.Hide();
        }

        private void AddProductEvent(object sender, EventArgs e)
        {
            try
            {
                // Validate changed OrderDetail values - Quantity
                string PID = _view.PID;
                if(_view.CallingForm.OD_OrderType!=2)//Stock
                _productModelServices.ValidateProductQuantity(PID, _view.Quantity);
                else
                     if (_view.Quantity <= 0)
                    throw new Exception("The stock must be larger 1 items");
                // Discount Range
                _productModelServices.ValidateOrderDiscount(_view.Quantity);

                _view.CallingForm.OD_PID = _view.PID;
                _view.CallingForm.OD_Discount = _view.Discount;
                _view.CallingForm.OD_Quantity = _view.Quantity;

                _view.CallingForm.AddNewProductOrderToList();

                _view.IsSuccessful = true;
                _view.Message = "";
                if (!_view.IsMultipleAdded)
                    _view.Hide();

            }
            catch (Exception Ex)
            {
                _view.IsSuccessful = false;
                _view.Message = Ex.Message;
                // Reset
                _view.Discount = 0;
                _view.Quantity = 1;
            }
        }
    }
}
