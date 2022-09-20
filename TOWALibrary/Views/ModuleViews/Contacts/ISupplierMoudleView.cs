using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Models.Inventory.Products;

namespace TOWALibrary.Views.ModuleViews.Contacts
{
    public interface ISupplierMoudleView
    {
        string SLID { get ; set ; }
        string SupplierName { get; set; }
         string ContactName { get; set; }
         string ContactPhone {get ; set ; }
         string Address { get; set; }
         string City {get ; set ; }
         string Country { get ; set ; }
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
        //Methods
        void SeSuplierListBindingSource(BindingSource supplierList);
        void Show();
    }
}
