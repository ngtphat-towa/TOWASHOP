using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Views.ModuleViews.Contacts;
using TOWALibrary.Views.ModuleViews.Inventory;
using TOWALibrary.Views.ModuleViews.Orders;
using TOWALibrary.Views.ModuleViews.Orders.OrderDetails;

namespace TOWALibrary.Views.MainViews
{
  public  interface IAdminView 
    {
        ISupplierModuleView SupplierModuleView { get; }
        ICustomerModuleView CustomerModuleView { get; }
        ICategoryModuleView CategoryModuleView { get; }
        IProductModuleView ProductModuleView { get; }
        IOrderListMoudleView  OrderListModuleView { get; }
        IOrderFormView OrderFormView { get; }
        
        event EventHandler ShowSupplierModuleView;
        event EventHandler ShowCustomerModuleView;
        event EventHandler ShowCategoryModuleView;
        event EventHandler ShowProductModuleView;
        event EventHandler ShowOrderListModuleView;
        event EventHandler ShowOrderFormView;
        void Show();
    }
}
