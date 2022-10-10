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
        event EventHandler ShowBillReviewByOrderEvent;
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        void SetOrderListViewBindingSource(BindingSource bindingSource);
        void SetOrderDetailsListViewBindingSource(BindingSource bindingSource);
        void Show();

    }
}
