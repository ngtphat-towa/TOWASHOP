using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Repositories.Inventory.Products;
using TOWALibrary.Repositories.Order.OrderDetails;
using TOWALibrary.Repositories.Order.Orders;
using TOWALibrary.Views.ModuleViews.Orders;

namespace NoUITowaShop.Module.Order
{
    public partial class OrderListModule : Form, IOrderListMoudleView
    {
        
        #region Contructor
        public OrderListModule()
        {
            InitializeComponent();

           

            this.dgvOrderList.SelectionChanged += delegate
            {
                ShowBillReviewByOrderEvent?.Invoke(this, EventArgs.Empty);
            };
            
        }
        #endregion


        #region Singleton
        private static OrderListModule instance;

        public event EventHandler ShowBillReviewByOrderEvent;
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public static OrderListModule GetInstance(Form parentContainer)
        {
            if (instance == null || ((Form)instance).IsDisposed)
            {
                instance = new OrderListModule();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {

                    instance.WindowState = parentContainer.WindowState;
                }

                instance.BringToFront();
            }
            return instance;
        }

        public void SetOrderListViewBindingSource(BindingSource bindingSource)
        {
            this.dgvOrderList.DataSource = bindingSource;
        }

        public void SetOrderDetailsListViewBindingSource(BindingSource bindingSource)
        {
            this.dgvOrderDetailsList.DataSource = bindingSource;
        }


        #endregion
    }
}
