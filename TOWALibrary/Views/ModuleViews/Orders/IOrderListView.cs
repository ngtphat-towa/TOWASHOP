using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOWALibrary.Views.ModuleViews.Orders
{
   public interface IOrderListMoudleView
    {
        event EventHandler SelectedOrderChangedEvent;
        event EventHandler OrderTypeChangedEvent;

        event EventHandler FilterChangedEvent;

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler RefreshEvent;

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
        void Show();

    }
}
