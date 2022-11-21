using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOWALibrary.Views.ModuleViews.Contacts
{
   public  interface ICustomerModuleView
    {
        string CTID { get; set; }
        string CID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string ContactPhone { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string Country { get; set; }
        string Content { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        string SearchValue { get; set; }
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        void SetListViewBindingSource(BindingSource bindingSource);
        void Show();
    }
}
