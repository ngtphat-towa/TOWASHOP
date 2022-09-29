using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Presenters.Modules.Contacts;
using TOWALibrary.Presenters.Modules.Inventory.Categories;
using TOWALibrary.Presenters.Modules.Inventory.Products;
using TOWALibrary.Repositories.Contacts.Suppliers;
using TOWALibrary.Repositories.Inventory.Categories;
using TOWALibrary.Repositories.Inventory.Products;
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
            this.view.ShowProductModuleView += ShowProductModuleView;
            this.view.Show();
        }

        private void ShowProductModuleView(object sender, EventArgs e)
        {
            IProductModuleView moduleView = view.ProductModuleView;
            IProductRepository repository = new ProductRepository(new SupplierRepository(),new CategoryRepository());
            new ProductModulePresenter(moduleView, repository);
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
