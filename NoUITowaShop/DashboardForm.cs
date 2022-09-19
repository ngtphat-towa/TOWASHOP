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

namespace SimpleUITowaShop
{
    public partial class DashboardForm : Form,IAdminView,IMainView
    {
        #region Contructor
        public DashboardForm()
        {
            InitializeComponent();
             Form _child = SupplierMoule.GetInstance(this);
            _child.Show();
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

    }
}
