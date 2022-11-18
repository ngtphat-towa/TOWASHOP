using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Models.Order.Orders;
using TOWALibrary.Repositories;
using TOWALibrary.Repositories.Order.CustomerOrder;
using TOWALibrary.Repositories.Order.Orders;
using TOWALibrary.Repositories.Order.SupplyOrders;
using TOWALibrary.Services.ModelServices.OrderServices;
using TOWALibrary.Views.ModuleViews.Orders;

namespace TOWALibrary.Presenters.Modules.Orders
{
   public class OrderListMoudlePresenter
    {
        private readonly IOrderListMoudleView view;
        private readonly IOrderServices services;
        // private readonly List<OrderModel> orderList;
        private readonly BindingSource orderListBindingSource;
        private BindingSource orderDetailListBindingSource;

        public OrderListMoudlePresenter(IOrderListMoudleView view, IOrderServices services)
        {
            this.view = view;
            this.services = services;
            this.orderListBindingSource = new BindingSource();
            this.orderDetailListBindingSource = new BindingSource();
            //Wire up event handler methods to view events
            this.view.SelectedOrderChangedEvent += ShowBillReviewByOrder;
           // this.view.SearchEvent += SearchOrder;
            this.view.AddNewEvent += AddNewOrder;
            this.view.EditEvent += LoadSelectedOrderToEdit;
            this.view.FilterChangedEvent += FilterChangedEvent;
            this.view.RefreshEvent += RefreshEvent;
            //this.view.OrderTypeChangedEvent += OrderTypeChangedEvent;

            //Set binding source
            this.view.SetOrderListViewBindingSource(orderListBindingSource);
            this.view.SetOrderDetailsListViewBindingSource(orderDetailListBindingSource);
            //LoadAllOrderList();
            //Show view
         
            this.view.Show();
            this.view.IsResetFilter = true;
            RefreshEvent(view, EventArgs.Empty);
        }

        private void RefreshEvent(object sender, EventArgs e)
        {
            //Initialize Order Type - Default is All
            this.view.OrderType = 0;

            //Initialize Order Status Type - Default is All
            this.view.OrderStatus = 0;

            // Initiallize Order Payment Method
            this.view.PaymentMethod  = 0;

            // Start at the monday of week
            //  this.datePickerFrom.Value = DateTime.Today.AddDays(1-Convert.ToDouble(DateTime.Today.DayOfWeek));

            // Set the date to the first date of month #Note: -1 for the datetime of example orders
            this.view.DateFrom = new DateTime(DateTime.Today.Year, DateTime.Today.Month - 1, 1);
            this.view.DateTo = DateTime.Today;
            //Reset Search value textbox
            this.view.SearchValue = "";

            // Handle to not reload multiple times
            this.view.IsResetFilter = false;
            FilterChangedEvent(this, EventArgs.Empty);
        }


        private void FilterChangedEvent(object sender, EventArgs e)
        {
            try
            {
                var SearchValue = "";
                if (this.view.IsValueSearch)
                    SearchValue = this.view.SearchValue;

                this.view.IsValueSearch = false;
                orderDetailListBindingSource.DataSource = null;
                services.SetOrderListByFilter(orderListBindingSource,
                                              SearchValue,
                                              this.view.OrderType,
                                              this.view.OrderStatus,
                                              this.view.PaymentMethod,
                                              this.view.DateFrom,
                                              this.view.DateTo);
                this.view.Message = "";
            }
            catch (Exception ex)
            {

                this.view.Message = ex.Message;
            }
          
        }

        private void CancelAction(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveOrder(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedOrderToEdit(object sender, EventArgs e)
        {
            if (orderListBindingSource == null)
            {
                this.view.Message = "The selected order is empty !";
                return;
            }
            

        }

        private void AddNewOrder(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        //private void SearchOrder(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private void ShowBillReviewByOrder(object sender, EventArgs e)
        {
            if (orderListBindingSource == null)
            {
                return;
            }
             
            OrderModel model = (OrderModel)orderListBindingSource.Current;
            if (model == null)
                return;
            this.orderDetailListBindingSource.DataSource = model.OrderDetails;
        }
    }
}
