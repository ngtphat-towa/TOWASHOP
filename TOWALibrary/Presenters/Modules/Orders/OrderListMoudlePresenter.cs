using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Models.Order.Orders;
using TOWALibrary.Presenters.Modules.Orders.OrderDetails;
using TOWALibrary.Repositories;
using TOWALibrary.Repositories.Order.CustomerOrder;
using TOWALibrary.Repositories.Order.Orders;
using TOWALibrary.Repositories.Order.SupplyOrders;
using TOWALibrary.Services.CategoryServices;
using TOWALibrary.Services.CommonServices;
using TOWALibrary.Services.ModelServices.CustomerServices;
using TOWALibrary.Services.ModelServices.OrderDetailServices;
using TOWALibrary.Services.ModelServices.OrderServices;
using TOWALibrary.Services.ModelServices.ProductServices;
using TOWALibrary.Services.ModelServices.SupplierServices;
using TOWALibrary.Views.ModuleViews.Orders;

namespace TOWALibrary.Presenters.Modules.Orders
{
   public class OrderListMoudlePresenter
    {
        private readonly IOrderListMoudleView _view;
        private readonly IOrderServices _orderServices =ServicesManager.OrderServices;

        //private List<OrderModel> orderList;
        private readonly BindingSource _orderListBindingSource;
        private BindingSource _orderDetailListBindingSource;

        public OrderListMoudlePresenter(IOrderListMoudleView view)
        {
            _view = view;
            //Intialize Binding sources
            _orderListBindingSource = new BindingSource();
            _orderDetailListBindingSource = new BindingSource();
            //Wire up event handler methods to view events
            _view.SelectedOrderChangedEvent += ShowBillReviewByOrder;
           // this.view.SearchEvent += SearchOrder;
            _view.AddNewEvent += AddNewOrder;
            _view.EditEvent += LoadSelectedOrderToEdit;
            _view.FilterChangedEvent += FilterChangedEvent;
            _view.RefreshEvent += RefreshEvent;
            
            //this.view.OrderTypeChangedEvent += OrderTypeChangedEvent;

            //Set binding source
            _view.SetOrderListViewBindingSource(_orderListBindingSource);
            _view.SetOrderDetailsListViewBindingSource(_orderDetailListBindingSource);
            //LoadAllOrderList();
            //Show view
         
            _view.Show();
            _view.IsResetFilter = true;
            RefreshEvent(view, EventArgs.Empty);
        }

        private void RefreshEvent(object sender, EventArgs e)
        {
            //Initialize Order Type - Default is All
            _view.OrderType = 0;

            //Initialize Order Status Type - Default is All
            _view.OrderStatus = 0;

            // Initiallize Order Payment Method
            _view.PaymentMethod  = 0;

            // Start at the monday of week
            //  this.datePickerFrom.Value = DateTime.Today.AddDays(1-Convert.ToDouble(DateTime.Today.DayOfWeek));

            // Set the date to the first date of month #Note: -1 for the datetime of example orders
            _view.DateFrom = new DateTime(DateTime.Today.Year, DateTime.Today.Month - 1, 1);
            _view.DateTo = DateTime.Today;
            //Reset Search value textbox
            _view.SearchValue = "";

            // Handle to not reload multiple times
            _view.IsResetFilter = false;
            FilterChangedEvent(this, EventArgs.Empty);
            UpdateStatisticalTables();

        }

        private void UpdateStatisticalTables()
        {
            if (_orderListBindingSource == null)
            {
                return;
            }
            List<OrderModel> orderModels = (List<OrderModel>)_orderListBindingSource.DataSource;

            var TotalNumberOrder = orderModels.Count;
            var TotalPaid = orderModels.Count(p=>p.Status ==1);
            var TotalStock = orderModels.Where(p => p.OrderType == 2).Sum(p => p.GrandTotal);
            var TotalSold = orderModels.Where(p => p.OrderType != 2 && p.Status ==1).Sum(p => p.GrandTotal);

            _view.TotalNumberOrder = TotalNumberOrder;
            _view.TotalPaid = TotalPaid;
            _view.TotalStock = TotalStock;
            _view.TotalSold = TotalSold;
        }

        private void FilterChangedEvent(object sender, EventArgs e)
        {
            try
            {
                var SearchValue = "";
                if (_view.IsValueSearch)
                    SearchValue = _view.SearchValue;

                _view.IsValueSearch = false;
                _orderDetailListBindingSource.DataSource = null;
                _orderServices.SetOrderListByFilter(_orderListBindingSource,
                                              SearchValue,
                                              _view.OrderType,
                                              _view.OrderStatus,
                                              _view.PaymentMethod,
                                              _view.DateFrom,
                                              _view.DateTo);
                _view.Message = "";
            }
            catch (Exception ex)
            {

                _view.Message = ex.Message;
            }
          
        }

   
        private void LoadSelectedOrderToEdit(object sender, EventArgs e)
        {

            try
            {
                if (_orderListBindingSource == null)
                    throw new Exception("The selected order is empty !");

                OrderModel model = (OrderModel)_orderListBindingSource.Current;
                if (model == null)
                    throw new Exception("Selected order can be load!");

                _view.OrderFormView.OID = model.OID;
                _view.OrderFormView.IsEditMode = true;
                _view.OrderFormView.IsChangeableOrdeType = false;

                _view.OrderFormView.CreatedByUID = model.CreatedByUID;
                //_view.OrderFormView.DateCreated

                // Order type info
                _view.OrderFormView.OrderType = model.OrderType;
                _view.OrderFormView.PaymentMethod = model.PaymentMethod;

                //meta
                _view.OrderFormView.OrderStatus = model.Status;
                _view.OrderFormView.CreatedAt = model.CreatedAt;

               

                _view.OrderFormView.LoadOrderToEdit();
                _view.OrderFormView.CallingForm = (IOrderFormRequest)_view;
                _view.OrderFormView.Show();
            }
            catch (Exception Ex)
            {
                _view.Message = "Error occured! Order failed to be modified! \n"+ Ex.Message;
                _view.IsSuccessful = false;
            }

        }

        private void AddNewOrder(object sender, EventArgs e)
        {
           _view.OrderFormView.Show();
        }


        private void ShowBillReviewByOrder(object sender, EventArgs e)
        {
            if (_orderListBindingSource == null)
            {
                return;
            }
             
            OrderModel model = (OrderModel)_orderListBindingSource.Current;
            if (model == null)
                return;

            int RoleView = GlobalConfig.CurrentUser.RoleID;
            string UID = GlobalConfig.CurrentUser.UID;

            _view.IsEditable = (model.Status != 1 && (RoleView==1 || model.CreatedByUID==UID));// Paid
            _orderDetailListBindingSource.DataSource = model.OrderDetails;
        }
    }
}
