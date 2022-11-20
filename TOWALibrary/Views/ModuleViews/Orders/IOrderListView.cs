using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Views.ModuleViews.Orders.OrderDetails;

namespace TOWALibrary.Views.ModuleViews.Orders
{
   public interface IOrderListMoudleView
    {
        event EventHandler SelectedOrderChangedEvent;
        // This for Order Type Changed, we reset control and load all
      //  event EventHandler OrderTypeChangedEvent;
        //This for status changed for Order Status or Date From/to 
        event EventHandler FilterChangedEvent;

        //event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler RefreshEvent;
        event EventHandler LoadEditOrderFormEvent;


        /// <summary>
        /// Set data grid view with the bindingSource of Order list
        /// </summary>
        /// <param name="bindingSource"></param>
        void SetOrderListViewBindingSource(BindingSource bindingSource);
        /// <summary>
        /// Set Order Details by Order
        /// </summary>
        /// <param name="bindingSource"></param>
        void SetOrderDetailsListViewBindingSource(BindingSource bindingSource);
        string SearchValue { get; set; }

        string Message { set; }

        IOrderFormView OrderFormView { get; }

        #region Order Type/Status Filter
        int OrderType { get; set; }
        int OrderStatus { get; set; }
        int PaymentMethod  { get; set; }
        bool IsValueSearch { get; set; }
        bool IsResetFilter { get; set; }
        bool IsEditOrder { get; set; }
        bool IsSuccessful { get; set; }
        bool IsEditable { get; set; }
        #endregion

        #region Statistical tables
        int TotalNumberOrder { get; set; }
        double TotalStock { get; set; }
        int TotalPaid { get; set; }
        double TotalSold { get; set; }
        #endregion

        #region FilterDateTime
        DateTime DateFrom { get; set; }
        DateTime DateTo { get; set; }
        #endregion
        void Show();

    }
}
