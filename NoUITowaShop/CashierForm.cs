using NoUITowaShop.Module.Contact;
using NoUITowaShop.Module.Order;
using SimpleUITowaShop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Presenters.MainViews;
using TOWALibrary.Views;
using TOWALibrary.Views.MainViews;
using TOWALibrary.Views.ModuleViews.Contacts;
using TOWALibrary.Views.ModuleViews.Orders;
using TOWALibrary.Views.ModuleViews.Orders.OrderDetails;

namespace NoUITowaShop
{
    public partial class CashierForm : Form, IEmployeeView
    {
        private EmployeePresenter presenter;
        public CashierForm()
        {
            InitializeComponent();
            presenter = new EmployeePresenter(this);

            AssociateAndRaiseViewEvents();
        }
        #region Wire Up MenuScrip

      
        public event EventHandler ShowOrderListModuleView;
        public event EventHandler ShowOrderFormView;
        public event EventHandler ShowCustomerModuleView;
        public event EventHandler LogoutEvent;

        private void AssociateAndRaiseViewEvents()
        {
            this.logOutToolStripMenuItem.Click += delegate
            {
                isLogout = true;
                LogoutEvent?.Invoke(this, EventArgs.Empty);
            };
            this.customerToolStripMenuItem.Click += delegate {
                ShowCustomerModuleView?.Invoke(this, EventArgs.Empty);
            };
            this.orderListToolStripMenuItem.Click += delegate
            {
                ShowOrderListModuleView?.Invoke(this, EventArgs.Empty);
            };
            this.newOrderToolStripMenuItem.Click += delegate
            {
                ShowOrderFormView?.Invoke(this, EventArgs.Empty);
            };
            this.FormClosing += (s, e) =>
            {
                if (e.CloseReason == CloseReason.UserClosing && !isLogout)
                {
                    DialogResult result = MessageBox.Show("Are you want to exit the application?", "", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                        Application.Exit();
                    else
                        e.Cancel = true;
                }

            };
        }

        #endregion

        #region Properties
     
        public IOrderListMoudleView OrderListModuleView
        {
            get => OrderListModule.GetInstance(this);
        }
        public IOrderFormView OrderFormView
        {
            get => OrderForm.Instance;
        }
        public ICustomerModuleView CustomerModuleView => CustomerModule.GetInstance(this);
        public ILoginView GetLoginView => LoginForm.Instance;

        private bool isLogout;
        public bool IsLogout { get => isLogout; set => isLogout = value; }

        #endregion

        #region Singleton
        private static IEmployeeView instance;

        public static IEmployeeView Instance
        {
            get
            {
                if (instance == null || ((Form)instance).IsDisposed)
                {
                    instance = new CashierForm();
                }
                return instance;
            }
        }
        #endregion
    }
}
