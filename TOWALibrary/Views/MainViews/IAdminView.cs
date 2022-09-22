using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Views.ModuleViews.Contacts;
using TOWALibrary.Views.ModuleViews.Inventory;

namespace TOWALibrary.Views.MainViews
{
  public  interface IAdminView 
    {
        ISupplierModuleView SupplierModuleView { get; }
        ICategoryModuleView CategoryModuleView { get; }
        event EventHandler ShowSupplierModuleView;
        event EventHandler ShowCategoryModuleView;
        void Show();
    }
}
