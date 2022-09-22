using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Presenters.Modules.Contacts;
using TOWALibrary.Presenters.Modules.Inventory.Categories;
using TOWALibrary.Repositories.Contacts.Suppliers;
using TOWALibrary.Repositories.Inventory.Categories;
using TOWALibrary.Views.MainViews;
using TOWALibrary.Views.ModuleViews.Contacts;
using TOWALibrary.Views.ModuleViews.Inventory;

namespace TOWALibrary.Presenters.MainViews
{
    public class AdminPresenter
    {
        private readonly IAdminView view;

        public AdminPresenter(IAdminView view)
        {
            this.view = view;
            this.view.ShowSupplierModuleView += ShowSupplierModuleView;
            this.view.ShowCategoryModuleView += ShowCategoryModuleView;
            this.view.Show();
        }

        private void ShowCategoryModuleView(object sender, EventArgs e)
        {
            ICategoryModuleView moduleView = view.CategoryModuleView;
            ICategoryRepository repository = new CategoryRepository();
            new CategoryModulePresenter(moduleView, repository);
        }

        private void ShowSupplierModuleView(object sender, EventArgs e)
        {
            ISupplierModuleView moduleView = view.SupplierModuleView;
            ISupplierRepository repository = new SupplierRepository();
            new SupplierModulePresenter(moduleView, repository);
        }

        
    }
}
