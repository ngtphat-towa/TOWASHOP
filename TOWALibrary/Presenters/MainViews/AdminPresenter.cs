using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Presenters.Modules.Contacts;
using TOWALibrary.Presenters.Modules.Inventory.Categories;
using TOWALibrary.Presenters.Modules.Inventory.Products;
using TOWALibrary.Presenters.Modules.Orders;
using TOWALibrary.Repositories;
using TOWALibrary.Repositories.Contacts.Suppliers;
using TOWALibrary.Repositories.Inventory.Categories;
using TOWALibrary.Repositories.Inventory.Products;
using TOWALibrary.Repositories.Order.Orders;
using TOWALibrary.Views.MainViews;
using TOWALibrary.Views.ModuleViews.Contacts;
using TOWALibrary.Views.ModuleViews.Inventory;
using TOWALibrary.Views.ModuleViews.Orders;

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
            this.view.ShowOrderListModuleView += ShowOrderListModuleView;
            this.view.Show();
        }

        private void ShowOrderListModuleView(object sender, EventArgs e)
        {
            IOrderListMoudleView moduleView = view.OrderListModuleView;
            IOrderRepository repository = DBManager.OrderRepository;
            new OrderListMoudlePresenter(moduleView, repository);
        }

        private void ShowProductModuleView(object sender, EventArgs e)
        {
            IProductModuleView moduleView = view.ProductModuleView;
            IProductRepository repository = DBManager.ProductRepository;
            new ProductModulePresenter(moduleView, repository);
        }

        private void ShowCategoryModuleView(object sender, EventArgs e)
        {
            ICategoryModuleView moduleView = view.CategoryModuleView;
            ICategoryRepository repository = DBManager.CategoryRepository;
            new CategoryModulePresenter(moduleView, repository);
        }

        private void ShowSupplierModuleView(object sender, EventArgs e)
        {
            ISupplierModuleView moduleView = view.SupplierModuleView;
            ISupplierRepository repository = DBManager.SupplierRepository;
            new SupplierModulePresenter(moduleView, repository);
        }

        
    }
}
