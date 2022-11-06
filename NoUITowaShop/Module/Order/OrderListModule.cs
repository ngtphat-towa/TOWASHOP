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

            // Initialize Filter
            string[] OrderType = new string[] { "All", "Retail Order", "Customer Order", "Supply Stock" };
            this.cbOrderType.DataSource = OrderType;
            string[] OrderStatusType = new string[] { "All", "New", "Paid", "Delivering" };
            this.cbStatus.DataSource = OrderStatusType;
            string[] PaymentMethod = new string[] { "All", "Cash", "Credit" };

            this.Load += delegate
            {
                // Handle to not reload mutipile times
                this.IsResetFilter = true;
                //Initialize Order Payment - Default is All
                this.cbPaymentMethod.DataSource = PaymentMethod;
                //Initialize Order Type - Default is All
                this.cbOrderType.SelectedIndex = 0;

                //Initialize Order Status Type - Default is All
                this.cbStatus.SelectedIndex = 0;

                // Initiallize Order Payment Method
                this.cbPaymentMethod.SelectedIndex = 0;
                // Start at the monday of week
                //  this.datePickerFrom.Value = DateTime.Today.AddDays(1-Convert.ToDouble(DateTime.Today.DayOfWeek));
                // Set the date to the first date of month #Note: -1 for the datetime of example orders
                this.datePickerFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month - 1, 1);

            };

            //this.Load += delegate
            //{
            //    this.
            //    FilterChangedEvent?.Invoke(this.cbOrderType, EventArgs.Empty);
            //};
            // This event will handle the filter: Order Type, Date Time
            #region FilterChangedEvent
            this.cbOrderType.SelectedIndexChanged += delegate
            {
                if (!IsResetFilter)
                    FilterChangedEvent?.Invoke(this.cbOrderType, EventArgs.Empty);
            };
            this.cbStatus.SelectedIndexChanged += delegate
            {
                if (!IsResetFilter)
                    FilterChangedEvent?.Invoke(this.cbStatus, EventArgs.Empty);
            };
            this.cbPaymentMethod.SelectedIndexChanged += delegate
             {
                 if (!IsResetFilter)
                     FilterChangedEvent?.Invoke(this.cbPaymentMethod, EventArgs.Empty);
             };

            this.datePickerFrom.ValueChanged += delegate
            {
                if (!IsResetFilter)
                    FilterChangedEvent?.Invoke(this.datePickerFrom, EventArgs.Empty);
            };
            this.datePickerTo.ValueChanged += delegate
            {
                if (!IsResetFilter)
                    FilterChangedEvent?.Invoke(this.datePickerTo, EventArgs.Empty);
            };

            #endregion

            // Automatically change the order details by selected order
            #region Order Details by selected order
            this.dgvOrderList.SelectionChanged += delegate
            {
                // Selected Order Changed -> Order Detail Changed
               // if (this.dgvOrderList.RowCount!=0)
                SelectedOrderChangedEvent?.Invoke(this, EventArgs.Empty);
            };
            //this.cbOrderType.SelectedIndexChanged += delegate
            //{
            //    // Choose to view by Order Type
            //    OrderTypeChangedEvent?.Invoke(this.cbOrderType, EventArgs.Empty);
            //};
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
            this.btnSearch.Click += delegate
            {
                // Navie 1 keyword for search
                this.IsValueSearch = true;
                FilterChangedEvent?.Invoke(this, EventArgs.Empty);
            };
            this.btnRefresh.Click += delegate
            {
                //Refresh control, Order type : All, Clean search value
                this.IsResetFilter = true;
                RefreshEvent?.Invoke(this, EventArgs.Empty);
            };
            #endregion
        }
        #endregion

        #region Function
        public void SetOrderListViewBindingSource(BindingSource bindingSource)
        {
            this.dgvOrderDetailsList.DataSource = null;
            this.dgvOrderList.DataSource = bindingSource;
        }

        public void SetOrderDetailsListViewBindingSource(BindingSource bindingSource)
        {
            this.dgvOrderDetailsList.DataSource = null;
            this.dgvOrderDetailsList.DataSource = bindingSource;
        }
        #endregion

        #region EvenHandler
        public event EventHandler SelectedOrderChangedEvent;
     //   public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler RefreshEvent;
        //public event EventHandler OrderTypeChangedEvent;
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
        #region Private

        #endregion
        public string SearchValue { get => this.txtSearch.Text; set=> txtSearch.Text= value; }
         public string Message {  set=> this.lbErrorMessage.Text= value; }
       public DateTime DateFrom { get => this.datePickerFrom.Value; set => this.datePickerFrom.Value = value; }
        public DateTime DateTo { get => this.datePickerTo.Value; set=> this.datePickerTo.Value= value; }
        public int OrderType { get => this.cbOrderType.SelectedIndex; set =>this.cbOrderType.SelectedIndex= value; }
        public int OrderStatus { get => this.cbStatus.SelectedIndex; set => this.cbStatus.SelectedIndex =value; }
        public int PaymentMethod  { get => this.cbPaymentMethod.SelectedIndex; set => this.cbPaymentMethod.SelectedIndex = value; }
        public bool IsValueSearch { get ; set  ; }
        public bool IsResetFilter { get ; set ; }
        public bool IsEditOrder { get ; set; }

        #endregion
    }
}
