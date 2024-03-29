﻿using NoUITowaShop.ModelListForm;
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
using TOWALibrary.Presenters.Modules.Orders;
using TOWALibrary.Presenters.Modules.Orders.OrderDetails;
using TOWALibrary.Views.ModelListVew;
using TOWALibrary.Views.ModelListViewRequester;
using TOWALibrary.Views.ModuleViews.Orders.OrderDetails;

namespace NoUITowaShop.Module.Order
{
    public partial class OrderForm : Form, IOrderFormView
    {
        private readonly OrderFormPresenter  presenter;
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
            this.btnShowProductList.Click += delegate
            {
                this.ShowProductListEvent?.Invoke(this, EventArgs.Empty);
            };
            this.txtProductSearch.KeyDown +=(s,e)=> 
             {
                 // TODO _thhs
                 if(e.KeyCode == Keys.Enter)
                 {
                     this.BarcodeIDChangedEvent?.Invoke(this, EventArgs.Empty);
                     if (!IsSuccessful)
                         MessageBox.Show(Message, "Warming", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             };
            this.Disposed += delegate
             {
                 customerOrderInfoControl.Dispose();
                 supplierOrderInfoControl.Dispose();
                 ProductListView.Dispose();
             };
            this.dgvOrderList.SelectionChanged += delegate
            {
                this.SelectedOrderDetailChangedEvent?.Invoke(this.dgvOrderList, EventArgs.Empty);
            };
            this.txtDiscountValue.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    this.EditOrderDetailValueEvent.Invoke(s, e);
                    if (!IsSuccessful)
                        MessageBox.Show(Message, "Warming", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            this.txtQuantityValue.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    this.EditOrderDetailValueEvent.Invoke(s, e);
                    if(!IsSuccessful)
                        MessageBox.Show(Message, "Warming", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            };
            this.btnSaveOrder.Click += delegate
             {
                 
                 DialogResult result = MessageBox.Show("Are you want to save this order?", "", MessageBoxButtons.YesNo);

                 if (result == DialogResult.Yes)
                 {
                     this.SaveOrderEvent?.Invoke(this, EventArgs.Empty);
                     MessageBox.Show(Message);
                 }    
                 
             };
            this.btnResetChange.Click += delegate
            {
                this.ResetOrderDetailListEvent?.Invoke(this, EventArgs.Empty);
            };
            this.btnRemoveProduct.Click += delegate
             {
                 this.RemoveSelectedOrderItemsEvent?.Invoke(this, EventArgs.Empty);
             };
            //this.btnCancel.Click += delegate
            // {
            //     if (this.IsEditMode)
            //     {
            //         DialogResult result = MessageBox.Show("Are you want to save this order?", "", MessageBoxButtons.YesNoCancel);
            //         this.IsEditMode = false;
            //         if (result == DialogResult.Yes)
            //         {
            //             this.SaveOrderEvent?.Invoke(this, EventArgs.Empty);
            //             MessageBox.Show(Message);
            //             this.Close();
            //         }
            //         else
            //            if (result == DialogResult.No)
            //             this.Close();
            //     }
          

            // };
            this.presenter = new OrderFormPresenter(this);

        }
        #region Custom Control
        private CustomerOrderInfo customerOrderInfoControl  => CustomerOrderInfo.Instance; 
        private SupplierOrderInfo supplierOrderInfoControl=> SupplierOrderInfo.Instance; 


        #endregion
        #region EventHandler
        public event EventHandler AddNewProductOrderEvent;
        public event EventHandler ResetOrderDetailListEvent;
        public event EventHandler OrderTypeChangedEvent;
        public event EventHandler ShowProductListEvent;
        public event EventHandler BarcodeIDChangedEvent;
        public event EventHandler SelectedOrderDetailChangedEvent;
        public event EventHandler EditOrderDetailValueEvent;
        public event EventHandler RemoveSelectedOrderItemsEvent;
        public event EventHandler SaveOrderEvent;
        public event EventHandler LoadEditOrderFormEvent;

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
                    instance.MdiParent = parentContainer;
                    instance.FormBorderStyle = FormBorderStyle.None;
                    instance.WindowState = parentContainer.WindowState;
                }

                instance.BringToFront();
            }
            return instance;
        }


        public void SetOrderInfoControl(UserControl userControl)
        {
                this.panelOrderControl.Controls.Add(userControl);
                userControl.Show();               
        }

        public void AddNewProductOrderToList()
        {
            AddNewProductOrderEvent?.Invoke(this, EventArgs.Empty);
        }

        public void SetProductOrderDetailBindingSource(BindingSource bindingSource)
        {
            this.dgvOrderList.DataSource = bindingSource;


        }



        public void SetCustomerNameListDetailBindingSource(BindingSource bindingSource)
        {
            this.customerOrderInfoControl.CustomerList.DataSource = bindingSource;

            this.customerOrderInfoControl.CustomerList.DisplayMember = "Name";
            this.customerOrderInfoControl.CustomerList.ValueMember = "ID";

            this.customerOrderInfoControl.PhoneNumber.DataBindings.Add("Text", bindingSource, "Phone");
        }

        public void SetSupplierNameListDetailBindingSource(BindingSource bindingSource)
        {
            this.supplierOrderInfoControl.SupplierList.DataSource = bindingSource;

            this.supplierOrderInfoControl.SupplierList.DisplayMember = "Name";
            this.supplierOrderInfoControl.SupplierList.ValueMember = "ID";

            this.supplierOrderInfoControl.PhoneNumber.DataBindings.Add("Text", bindingSource, "Phone");
        }

        public void LoadOrderToEdit()
        {
            this.LoadEditOrderFormEvent?.Invoke(this, EventArgs.Empty);
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
               // instance.TopMost = true;
                instance.StartPosition = FormStartPosition.CenterScreen;
                instance.BringToFront();
                return instance;
            }
        }


        #endregion
        #region Attribute
        public int OrderType { get => this.cbOrderType.SelectedIndex; set => this.cbOrderType.SelectedIndex = value; }
        public int OrderStatus { get => this.cbOrderStatus.SelectedIndex; set => this.cbOrderStatus.SelectedIndex = value; }
        public int PaymentMethod { 
            get => (this.rbtnIsCash.Checked)? 0 : 1; 
            set {
                this.rbtnIsCash.Checked = (value == 0);
            }
        }
        public string CustomerPhone { get => this.customerOrderInfoControl.PhoneNumber.Text; set =>this.customerOrderInfoControl.PhoneNumber.Text=value; }
        public string SupplierPhone { get => this.supplierOrderInfoControl.PhoneNumber.Text; set => this.supplierOrderInfoControl.PhoneNumber.Text = value; }
        public UserControl CustomerOrderInfoControl { get => customerOrderInfoControl; }
        public UserControl SupplierOrderInfoControl { get => supplierOrderInfoControl; }

        public IProductListView ProductListView => ProductListForm.GetIntance(this);
        #region Add new product
        public string OD_PID { get ; set; }
        public double OD_Discount { get ; set ; }
        public int OD_Quantity { get ; set ; }
        public int OD_OrderType { get => OrderType; }

        #endregion
        public double DiscountValue { get =>Convert.ToDouble( this.txtDiscountValue.Value); set => this.txtDiscountValue.Value = Convert.ToDecimal(value); }
        public int QuantityValue { get => Convert.ToInt32(this.txtQuantityValue.Value); set => this.txtQuantityValue.Value= Convert.ToDecimal(value); }
        private int _OID;
        public int OID
        {
            get => _OID; set
            {
                if (value != 0)
                    this.lbOID.Text ="ID: "+ value.ToString();
                else
                    this.lbOID.Text = "New Order";

                _OID = value;
            }
        }
        public bool IsEditMode { get ; set ; }
        public string CreatedByUID { get =>  this.lbCreatedByAccount.Text ; set => this.lbCreatedByAccount.Text = value; }
        public string Message { get ; set; }
        public bool IsSuccessful { get ; set ; }
        public double Total { get => Convert.ToDouble(txtTotal.Text); set => txtTotal.Text = value.ToString(); }
        public double GrandTotal { get => Convert.ToDouble(lbGrandTotoal.Text); set => lbGrandTotoal.Text = value.ToString(); }
        public double TotalDiscount { get => Convert.ToDouble(txtTotalDiscount.Text); set => txtTotalDiscount.Text =value.ToString(); }
        public string SLID { get => supplierOrderInfoControl.SupplierList.SelectedValue.ToString() ; set => supplierOrderInfoControl.SupplierList.SelectedValue= value; }
        public string CTID { get => customerOrderInfoControl.CustomerList.SelectedValue.ToString(); set => customerOrderInfoControl.CustomerList.SelectedValue = value; }
        public string Comments { get => txtComment.Text; set => txtComment.Text = value; }
        public DateTime CreatedAt { get => dateCreatedAt.Value; set => dateCreatedAt.Value =value; }
        public IOrderFormRequest CallingForm { get ; set ; }
        public string ProductSearch { get => this.txtProductSearch.Text; set => this.txtProductSearch.Text= value; }
        public bool IsChangeableOrdeType { get => this.cbOrderType.Enabled; set => this.cbOrderType.Enabled= value; }

        #endregion

    }
}
