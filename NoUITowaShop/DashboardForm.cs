using NoUITowaShop.Module.Contact;
using NoUITowaShop.Module.Inventory;
using NoUITowaShop.Module.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Views;
using TOWALibrary.Views.MainViews;
using TOWALibrary.Views.ModuleViews.Contacts;
using TOWALibrary.Views.ModuleViews.Inventory;

namespace SimpleUITowaShop
{
    public partial class DashboardForm : Form,IAdminView
    {
        #region Contructor
        public DashboardForm()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }
        #endregion

        #region Wire Up MenuScrip
        public event EventHandler ShowSupplierModuleView;
        public event EventHandler ShowCategoryModuleView;
        public event EventHandler ShowProductModuleView;

        private void AssociateAndRaiseViewEvents()
        {
            this.supplierToolStripMenuItem.Click += delegate {
                ShowSupplierModuleView?.Invoke(this,EventArgs.Empty);
            };
            this.categoriesToolStripMenuItem.Click += delegate
             {
                 ShowCategoryModuleView?.Invoke(this, EventArgs.Empty);
             };
            this.productsToolStripMenuItem.Click += delegate
            {
                ShowProductModuleView?.Invoke(this, EventArgs.Empty);
            };
            this.FormClosed += delegate
            {
                if (MessageBox.Show("Are you want to exit the application?","",MessageBoxButtons.YesNo)==DialogResult.Yes)
                    Application.Exit();
            };
        }

        #endregion

        #region Properties
        public ISupplierModuleView SupplierModuleView
        {
            get => SupplierModule.GetInstance(this);
            
        }
        public ICategoryModuleView CategoryModuleView
        {
            get => CategoryModule.GetInstance(this);
        }
        public IProductModuleView ProductModuleView
        {
            get => ProductModule.GetInstance(this);
        }

        #endregion

        #region Singleton
        private static IAdminView instance;

        public static IAdminView Instance
        {
            get
            {
                if ( instance==null || ((Form)instance).IsDisposed)
                {
                    instance = new DashboardForm();
                }
                return instance;
            }
        }


        #endregion



    }
}
