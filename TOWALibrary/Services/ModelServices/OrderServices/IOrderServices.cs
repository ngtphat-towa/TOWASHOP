using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Models.Order.OrderDetails;
using TOWALibrary.Repositories.Order.Orders;
using TOWALibrary.Services.ModelServices.OrderServices.OrderType.CustomerOrder;
using TOWALibrary.Services.ModelServices.OrderServices.OrderType.Order;
using TOWALibrary.Services.ModelServices.OrderServices.OrderType.StockOrder;

namespace TOWALibrary.Services.ModelServices.OrderServices
{
  public  interface IOrderServices 
    {
        IOrderModelServices OrderModelServices { get;  }
        ICustomerOrderModelServices CustomerOrderModelServices { get; }
        IStockOrderModelServices StockOrderModelServices { get; }
        void SetOrderListByFilter(BindingSource source, string SearchValue, int OrderType, int OrderStatus, int PaymentMethod, DateTime DateFrom, DateTime DateTo);
         void AddNewOrder(List<OrderDetailModel> orderDetails,int OrderType, int OrderStatus, int PaymentMethod);
    }
}
