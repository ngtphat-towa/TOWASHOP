using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Views.ModuleViews.Contacts;
using TOWALibrary.Views.ModuleViews.Inventory;
using TOWALibrary.Views.ModuleViews.Orders;

namespace TOWALibrary.Views.MainViews
{
  public  interface IAdminView 
    {
        ISupplierModuleView SupplierModuleView { get; }
        ICategoryModuleView CategoryModuleView { get; }
        IProductModuleView ProductModuleView { get; }
        IOrderListMoudleView  OrderListModuleView { get; }
        event EventHandler ShowSupplierModuleView;
        event EventHandler ShowCategoryModuleView;
        event EventHandler ShowProductModuleView;
        event EventHandler ShowOrderListModuleView;
        void Show();
    }
}
