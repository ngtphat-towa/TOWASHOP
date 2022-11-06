using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOWALibrary.Views.ModuleViews.Orders.OrderDetails
{
   public interface IOrderFormView
    {
        
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler RefreshEvent;
        event EventHandler OrderTypeChangedEvent;
        #region Order Type/Status 
        int OrderType { get; set; }
        int OrderStatus { get; set; }
        int PaymentMethod  { get; set; }
        string CustomerPhone { get; set; }
        string SupplierPhone { get; set; }
        UserControl CustomerOrderInfoControl { get; }
        UserControl SupplierOrderInfoControl { get; }
        void SetSupplierListViewBindingSource(BindingSource bindingSource);
        void SetCustomerListViewBindingSource(BindingSource bindingSource);
        void SetOrderInfoControl(UserControl userControl);
        #endregion
        void Show();
    }
}
