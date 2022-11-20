using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Models.Order.OrderDetails;
using TOWALibrary.Models.Order.Orders;
using TOWALibrary.Models.Order.OrderType;
using TOWALibrary.Repositories;
using TOWALibrary.Repositories.Order.CustomerOrder;
using TOWALibrary.Repositories.Order.OrderDetails;
using TOWALibrary.Repositories.Order.Orders;
using TOWALibrary.Repositories.Order.SupplyOrders;
using TOWALibrary.Services.CommonServices;
using TOWALibrary.Services.ModelServices.OrderServices.OrderType.CustomerOrder;
using TOWALibrary.Services.ModelServices.OrderServices.OrderType.Order;
using TOWALibrary.Services.ModelServices.OrderServices.OrderType.StockOrder;

namespace TOWALibrary.Services.ModelServices.OrderServices
{
    public class OrderServices : IOrderServices
    {
        readonly IStockOrderModelServices stockOrderServices= ServicesManager.StockOrderModelServices;
        readonly ICustomerOrderModelServices customerOrderServices = ServicesManager.CustomerOrderModelServices;
        readonly IOrderModelServices orderModelServices = ServicesManager.OrderModelServices;

        public OrderServices()
        {
        }

        public IOrderModelServices OrderModelServices { get => orderModelServices;  }
        public IStockOrderModelServices StockOrderModelServices { get => stockOrderServices; }

        public ICustomerOrderModelServices CustomerOrderModelServices => customerOrderServices;

        public void AddNewOrder(List<OrderDetailModel> orderDetails, int OrderType, int OrderStatus, int PaymentMethod)
        {
            throw new NotImplementedException();
        }

        public void SetOrderListByFilter(BindingSource source, string SearchValue, int OrderType, int OrderStatus, int PaymentMethod, DateTime DateFrom, DateTime DateTo)
        {
            source.DataSource = null;
            DateTo = DateTo.AddDays(1);
            switch (OrderType)
            {
                case 1:
                    // Order Type 0 only = Order Retails 
                    var retailOrderList = orderModelServices.GetByValue(SearchValue)
                        .Where(m => m.OrderType == 0 && m.ISCreatedDateFromTo(DateFrom, DateTo))
                        .Where(m => OrderStatus == 0 || m.Status + 1 == OrderStatus)
                        .Where(m =>PaymentMethod ==0 || m.PaymentMethod + 1 == PaymentMethod).ToList();

                    if (retailOrderList.Count == 0)
                        throw new Exception("No retail orders exists as search value!");

                    source.DataSource = retailOrderList;
                    break;
                case 2:
                    var customerOrderList = customerOrderServices.GetByValue(SearchValue)
                        .Where(m => m.ISCreatedDateFromTo(DateFrom, DateTo))
                        .Where(m => OrderStatus == 0 || m.Status + 1 == OrderStatus)
                        .Where(m => PaymentMethod == 0 || m.PaymentMethod + 1 == PaymentMethod).ToList();

                    if (customerOrderList.Count == 0)
                        throw new Exception("No customer orders exists as search value!");

                    source.DataSource = customerOrderList;
                    break;
                case 3:
                    var stockOrderList = stockOrderServices.GetByValue(SearchValue)
                        .Where(m =>  m.ISCreatedDateFromTo(DateFrom, DateTo))
                        .Where(m => OrderStatus == 0 || m.Status + 1 == OrderStatus)
                        .Where(m => PaymentMethod == 0 || m.PaymentMethod + 1 == PaymentMethod).ToList();

                    if (stockOrderList.Count == 0)
                        throw new Exception("No stock orders exists as search value!");


                    source.DataSource = stockOrderList;
                    break;
                default:
                    var orderList = orderModelServices.GetByValue(SearchValue)
                        .Where(m =>   m.ISCreatedDateFromTo(DateFrom, DateTo))
                        .Where(m => OrderStatus == 0 || m.Status + 1 == OrderStatus)
                        .Where(m => PaymentMethod == 0 || m.PaymentMethod + 1 == PaymentMethod).ToList();

                    if (orderList.Count == 0)
                        throw new Exception("No orders exists as search value!");

                    source.DataSource = orderList;
                    break;
            }
        }
    }
}
