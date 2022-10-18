﻿using System;
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

            //Initialize Filter
            this.Load += delegate
            {
                //Initialize Order Type - Default is All
                string[] OrderType = new string[] { "All", "Retail Order", "Customer Order", "Supply Stock" };
                this.cbOrderType.DataSource = OrderType;
                this.cbOrderType.SelectedIndex = 0;
            };

            // This event will handle the filter: Order Type, Date Time
            #region FilterChangedEvent
            this.cbOrderType.SelectedIndexChanged += delegate
            {
                FilterChangedEvent?.Invoke(this.cbOrderType, EventArgs.Empty);
            };

            this.datePickerFrom.ValueChanged += delegate
            {
                FilterChangedEvent?.Invoke(this.cbOrderType, EventArgs.Empty);
            };
            this.datePickerTo.ValueChanged += delegate
            {
                FilterChangedEvent?.Invoke(this.cbOrderType, EventArgs.Empty);
            };
            #endregion

            // Automatically change the order details by selected order
            #region Order Details by selected order
            this.dgvOrderList.SelectionChanged += delegate
            {
                // Selected Order Changed -> Order Detail Changed
                SelectedOrderChangedEvent?.Invoke(this, EventArgs.Empty);
            };
            this.cbOrderType.SelectedIndexChanged += delegate
            {
                // Choose to view by Order Type
                OrderTypeChangedEvent?.Invoke(this.cbOrderType, EventArgs.Empty);
            };
            #endregion

            // Those event is main CURDS event to handle Order,Order Details
            #region Major Option 
            this.btnNew.Click += delegate
            {
                // Open then moudule to create new Order
                AddNewEvent?.Invoke(this, EventArgs.Empty);
            };
            this.btnEdit.Click += delegate
            {
                // To edit the order not paid
                EditEvent?.Invoke(this, EventArgs.Empty);
            };
            this.txtSearch.TextChanged += delegate
            {
                // Navie 1 keyword for search
                SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            this.btnRefresh.Click += delegate
            {
                //Refresh control, Order type : All, Clean search value
                RefreshEvent?.Invoke(this, EventArgs.Empty);
                #endregion

            };
        }
        #endregion

        #region Function
        public void SetOrderListViewBindingSource(BindingSource bindingSource)
        {
            this.dgvOrderList.DataSource = bindingSource;
        }

        public void SetOrderDetailsListViewBindingSource(BindingSource bindingSource)
        {
            this.dgvOrderDetailsList.DataSource = bindingSource;
        }
        #endregion

        #region EvenHandler
        public event EventHandler SelectedOrderChangedEvent;
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler RefreshEvent;
        public event EventHandler OrderTypeChangedEvent;
        public event EventHandler FilterChangedEvent;
        #endregion

        #region Singleton
        private static OrderListModule instance;
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
        #endregion

        #region Attribute
        public string SearchValue { get => this.txtSearch.Text; set=> txtSearch.Text= value; }
       public string Message {  set=> this.lbErrorMessage.Text= value; }
        #endregion
    }
}
