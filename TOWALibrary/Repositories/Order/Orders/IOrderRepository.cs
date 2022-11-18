using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Order.Orders;

namespace TOWALibrary.Repositories.Order.Orders
{
   public interface IOrderRepository 
    {
        ICollection<OrderModel> GetAll();
        ICollection<OrderModel> GetByValue(string value);
        void Update(OrderModel model);
        void Add(OrderModel model);

    }
}
