using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Order.Orders;
using TOWALibrary.Repositories.Order.Orders;

namespace TOWALibrary.Services.ModelServices.OrderServices.OrderType.Order
{
    public  interface IOrderModelServices: IOrderRepository
    {
        void ValidateModel(OrderModel model);
        
    }
}
