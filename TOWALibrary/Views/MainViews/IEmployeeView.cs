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
    public interface IEmployeeView :IMainView
    {
        ICustomerModuleView CustomerModuleView { get; }
        IOrderListMoudleView OrderListModuleView { get; }
        IOrderFormView OrderFormView { get; }


        event EventHandler ShowCustomerModuleView;
        event EventHandler ShowOrderListModuleView;
        event EventHandler ShowOrderFormView;
    }
}
