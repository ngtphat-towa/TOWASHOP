using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Models.Order.OrderType;
using TOWALibrary.Presenters.Modules.Contacts;
using TOWALibrary.Presenters.Modules.Inventory.Categories;
using TOWALibrary.Presenters.Modules.Inventory.Products;
using TOWALibrary.Presenters.Modules.Orders;
using TOWALibrary.Presenters.Modules.Orders.OrderDetails;
using TOWALibrary.Repositories;
using TOWALibrary.Repositories.Contacts.Suppliers;
using TOWALibrary.Repositories.Inventory.Categories;
using TOWALibrary.Repositories.Inventory.Products;
using TOWALibrary.Repositories.Order.Orders;
using TOWALibrary.Services.CategoryServices;
using TOWALibrary.Services.ModelServices.CustomerServices;
using TOWALibrary.Services.ModelServices.OrderDetailServices;
using TOWALibrary.Services.ModelServices.OrderServices;
using TOWALibrary.Services.ModelServices.OrderServices.OrderType.CustomerOrder;
using TOWALibrary.Services.ModelServices.OrderServices.OrderType.Order;
using TOWALibrary.Services.ModelServices.OrderServices.OrderType.StockOrder;
using TOWALibrary.Services.ModelServices.ProductServices;
using TOWALibrary.Services.ModelServices.SupplierServices;
using TOWALibrary.Views;
using TOWALibrary.Views.MainViews;
using TOWALibrary.Views.ModuleViews.Contacts;
using TOWALibrary.Views.ModuleViews.Inventory;
using TOWALibrary.Views.ModuleViews.Orders;
using TOWALibrary.Views.ModuleViews.Orders.OrderDetails;

namespace TOWALibrary.Presenters.MainViews
{
    public class AdminPresenter
    {
        private readonly IAdminView view;
        //// Inventory
        #region Inventory Servives
        //private IProductModelServices _productModelServices;
        //private ICategoryModelServices _categoryModelServices;
        //#endregion

        //#region Contact Services
        //private ISupplierModelServices _supplierModelServices;
        //private ICustomerModelServices _customerModelServices;
        //#endregion

        //#region Order Serivces 

        //// Order Type
        //private IStockOrderModelServices _stockOrderModelServices;
        //private ICustomerOrderModelServices _customerOrderModelServices;
        //private IOrderModelServices _orderModelServices;
        #endregion

        public AdminPresenter(IAdminView view)
        {
            this.view = view;
            this.view.ShowSupplierModuleView += ShowSupplierModuleView;
            this.view.ShowCategoryModuleView += ShowCategoryModuleView;
            this.view.ShowProductModuleView += ShowProductModuleView;
            this.view.ShowOrderListModuleView += ShowOrderListModuleView;
            this.view.ShowOrderFormView += ShowOrderFormView;
            this.view.ShowCustomerModuleView += ShowCustomerModuleView;
            this.view.LogoutEvent += LogoutEvent;
            ////Inventory Servives
            //_productModelServices = new ProductModelServices();
            //_categoryModelServices = new CategoryModelServices();
        
            //// Contact Services
            //_supplierModelServices = new SupplierModelServices();
            //_customerModelServices = new CustomerModelServices();

            //// Orderr Type
            //_stockOrderModelServices = new StockOrderModelServices();
            //_customerOrderModelServices = new CustomerOrderModelServices();
            //_orderModelServices = new OrderModelServices();
          //  this.view.Show();


        }

        private void LogoutEvent(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you want to log out ?", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                view.Close();
                view.GetLoginView.GetNewLogin();
            }
     
        }

        private void ShowCustomerModuleView(object sender, EventArgs e)
        {
            view.CustomerModuleView.Show();
        }

        private void ShowOrderFormView(object sender, EventArgs e)
        {
            view.OrderFormView.Show();
        }

        private void ShowOrderListModuleView(object sender, EventArgs e)
        {
            view.OrderListModuleView.Show();
        }

        private void ShowProductModuleView(object sender, EventArgs e)
        {
            view.ProductModuleView.Show();
        }

        private void ShowCategoryModuleView(object sender, EventArgs e)
        {
            view.CategoryModuleView.Show();
        }

        private void ShowSupplierModuleView(object sender, EventArgs e)
        {
            view.SupplierModuleView.Show();
        }

        
    }
}
