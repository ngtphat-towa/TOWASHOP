using NoUITowaShop.Module.Order.OrderPanel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Views.ModuleViews.Orders.OrderDetails;

namespace NoUITowaShop.Module.Order
{
    public partial class OrderForm : Form, IOrderFormView
    {
        public OrderForm()
        {
            InitializeComponent();
            // Initialize Filter
            string[] OrderType = new string[] { "Retail Order", "Customer Order", "Supply Stock" };
            this.cbOrderType.DataSource = OrderType;
            string[] OrderStatusType = new string[] { "New", "Paid", "Delivering" };
            this.cbOrderStatus.DataSource = OrderStatusType;
            //  string[] PaymentMethod = new string[] { "All", "Cash", "Credit" };
            this.cbOrderStatus.SelectedIndex = 0;
            this.cbOrderStatus.SelectedIndex = 1;
            this.cbOrderType.SelectedIndexChanged += delegate
             {
                 this.panelOrderControl.Controls.Clear();
                 OrderTypeChangedEvent?.Invoke(this, EventArgs.Empty);
             };
        }
        #region Custom Control
        private CustomerOrderInfo customerOrderInfoControl  => CustomerOrderInfo.Instance; 
        private SupplierOrderInfo supplierOrderInfoControl=> SupplierOrderInfo.Instance; 


        #endregion
        #region EventHandler
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler RefreshEvent;
        public event EventHandler OrderTypeChangedEvent;
        #endregion

        #region Singleton

        private static OrderForm instance;


        // with parent Container
        public static OrderForm GetInstance(Form parentContainer)
        {
            if (instance == null || ((Form)instance).IsDisposed)
            {
                instance = new OrderForm();
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

        public void SetSupplierListViewBindingSource(BindingSource bindingSource)
        {
           this.supplierOrderInfoControl.SupplierList.DataSource = bindingSource;
        }

        public void SetCustomerListViewBindingSource(BindingSource bindingSource)
        {
            this.customerOrderInfoControl.CustomerList.DataSource = bindingSource;
        }

        public void SetOrderInfoControl(UserControl userControl)
        {
                this.panelOrderControl.Controls.Add(userControl);
                userControl.Show();               
        }

        public static OrderForm Instance
        {
            get
            {
                if (instance == null || ((Form)instance).IsDisposed)
                {
                    instance = new OrderForm();
                }
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
                instance.FormBorderStyle = FormBorderStyle.FixedSingle;
                instance.TopMost = true;
                instance.BringToFront();
                return instance;
            }
        }


        #endregion
        #region Attribute
        public int OrderType { get => this.cbOrderType.SelectedIndex; set => this.cbOrderType.SelectedIndex = value; }
        public int OrderStatus { get => this.cbOrderStatus.SelectedIndex; set => this.cbOrderStatus.SelectedIndex = value; }
        public int PaymentMethod { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomerPhone { get => this.customerOrderInfoControl.PhoneNumber.Text; set =>this.customerOrderInfoControl.PhoneNumber.Text=value; }
        public string SupplierPhone { get => this.supplierOrderInfoControl.PhoneNumber.Text; set => this.supplierOrderInfoControl.PhoneNumber.Text = value; }
        public UserControl CustomerOrderInfoControl { get => customerOrderInfoControl; }
        public UserControl SupplierOrderInfoControl { get => supplierOrderInfoControl; }


        #endregion

    }
}
