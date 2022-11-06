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

namespace TOWALibrary.Presenters.Modules.Orders
{
  public static class OrderListFilter

    {
        private static readonly IOrderRepository orderRepository = DBManager.OrderRepository;
        private static readonly ICustomerOrderRepository customerOrderRepository = DBManager.CustomerOrderRepository;
        private static readonly IStockOrderRepository stockOrderRepository = DBManager.StockOrderRepository;
        public static void SetOrderListByFilter(this BindingSource source, string SearchValue, int OrderType, int OrderStatus,int PaymentMethod , DateTime DateFrom, DateTime DateTo)
        {
            source.DataSource = null;
            switch (OrderType)
            {
                case 1:
                    // Order Type 0 only = Order Retails 
                    var retailOrderList = orderRepository.GetByValue(SearchValue).Where(m => m.OrderType == 0 && m.ISCreatedDateFromTo(DateFrom, DateTo) ).ToList();
                
                    if (retailOrderList.Count == 0)
                        throw new Exception("No retail orders exists as search value!");

                    if (OrderStatus != 0)
                        retailOrderList = retailOrderList.Where(m => m.Status + 1 == OrderStatus).ToList();

                    if (PaymentMethod  != 0)
                        retailOrderList = retailOrderList.Where(m => m.PaymentMethod + 1 == PaymentMethod ).ToList();

                    source.DataSource = retailOrderList;
                    break;
                case 2:
                    var customerOrderList = customerOrderRepository.GetByValue(SearchValue).Where(m => m.ISCreatedDateFromTo(DateFrom, DateTo)).ToList();
                    
                    if (customerOrderList.Count == 0)
                        throw new Exception("No customer orders exists as search value!");

                    if (OrderStatus != 0)
                        customerOrderList = customerOrderList.Where(m => m.Status + 1 == OrderStatus).ToList();

                    if (PaymentMethod  != 0)
                        customerOrderList = customerOrderList.Where(m => m.PaymentMethod + 1 == PaymentMethod ).ToList();

                    source.DataSource = customerOrderList;
                    break;
                case 3:
                    var stockOrderList = stockOrderRepository.GetByValue(SearchValue).Where(m => m.ISCreatedDateFromTo(DateFrom, DateTo)).ToList();

                    if (stockOrderList.Count == 0)
                        throw new Exception("No stock orders exists as search value!");

                    if (OrderStatus != 0)
                        stockOrderList = stockOrderList.Where(m => m.Status + 1 == OrderStatus).ToList();

                    if (PaymentMethod  != 0)
                        stockOrderList = stockOrderList.Where(m => m.PaymentMethod + 1 == PaymentMethod ).ToList();

                    source.DataSource = stockOrderList;
                    break;
                default:
                    var orderList = orderRepository.GetByValue(SearchValue).Where(m => m.ISCreatedDateFromTo(DateFrom, DateTo)).ToList();

                    if (orderList.Count == 0)
                        throw new Exception("No orders exists as search value!");

                    if (OrderStatus != 0)
                        orderList = orderList.Where(m => m.Status + 1 == OrderStatus).ToList();

                    if (PaymentMethod  != 0)
                        orderList = orderList.Where(m => m.PaymentMethod + 1 == PaymentMethod ).ToList();

                    source.DataSource = orderList;
                    break;
            }
        }

    }
}
