using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Presenters.Modules.Contacts;
using TOWALibrary.Repositories.Contacts.Suppliers;
using TOWALibrary.Views.MainViews;
using TOWALibrary.Views.ModuleViews.Contacts;

namespace TOWALibrary.Presenters.MainViews
{
    public class AdminPresenter
    {
        private readonly IAdminView view;

        public AdminPresenter(IAdminView view)
        {
            this.view = view;
            this.view.ShowSupplierModuleView += ShowSupplierModuleView;
            this.view.Show();
        }

        private void ShowSupplierModuleView(object sender, EventArgs e)
        {
            ISupplierMoudleView supplierMoudle = view.SupplierModuleView;
            ISupplierRepository repository = new SupplierRepository();
            new SupplierModulePresenter(supplierMoudle, repository);
        }

        
    }
}
