using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Views.ModuleViews.Contacts;

namespace TOWALibrary.Views.MainViews
{
  public  interface IAdminView 
    {
        ISupplierMoudleView SupplierModuleView { get; }
        event EventHandler ShowSupplierModuleView;
        void Show();
    }
}
