using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOWALibrary.Views.ModuleViews.Inventory
{
    public interface ICategoryModuleView
    {
        int CATEID { get ; set ; }
        string CategoryName { get ; set ; }
        string Description { get ; set ; }
        string Content { get ; set ; }
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
