using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Models.Contact.Suppliers;
using TOWALibrary.Models.Inventory.Categoires;

namespace TOWALibrary.Views.ModuleViews.Inventory
{
    public interface IProductModuleView
    {
         string PID { get ; set ; }
        string ProductName { get ; set ; }
         string Barcode { get; set; }
         string QuantityPerUnit { get; set; }
         double UnitPrice { get; set; }
        double SalesPrice { get; set; }
         int UnitOnStock { get; set; }
        int UnitOnOrder { get; set; }
         double VAT { get ; set ; }
         string Status { get; set; }
         string Content { get ; set ; }
        bool IsSuccessful { get; set; }
        bool IsEdit { get; set; }
        string Message { get; set; }
        string SelectedSLID { get; set; }
        int SelectedCID { get; set; }
        string SelectedSLIDName { get; set; }
        int SelectedCIDName { get; set; }
        bool IsValueSearch { get; set; }
        void SetSupplierList(BindingSource bindingSource);
        void SetCategoryList(BindingSource bindingSource);
        void SetCategoryNameListBindingSource(BindingSource bindingSource);
        void SetSupplierNameListBindingSource(BindingSource bindingSource);
        void SetListViewBindingSource(BindingSource bindingSource);
        string SearchValue { get; set; }
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        
        void Show();
      
    }
}
