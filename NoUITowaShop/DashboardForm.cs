using NoUITowaShop.Module.Contact;
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

namespace SimpleUITowaShop
{
    public partial class DashboardForm : Form,IAdminView
    {
        #region Contructor
        public DashboardForm()
        {
            InitializeComponent();
            // Form _child =(Form) SupplierMoule.GetInstance(this);
            //_child.Show();
            AssociateAndRaiseViewEvents();
        }
        #endregion

        #region Wire Up MenuScrip
        public event EventHandler ShowSupplierModuleView;
        private void AssociateAndRaiseViewEvents()
        {
            this.supplierToolStripMenuItem.Click += delegate {
                ShowSupplierModuleView?.Invoke(this,EventArgs.Empty);
            };
            this.FormClosed += delegate
            {
                Application.Exit();
            };
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


        public ISupplierMoudleView SupplierModuleView
        {
            get
            {
                return SupplierMoule.GetInstance(this);
            }
        }
    }
}
