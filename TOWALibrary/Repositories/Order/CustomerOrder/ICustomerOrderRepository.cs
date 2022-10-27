using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Order.OrderType;

namespace TOWALibrary.Repositories.Order.CustomerOrder
{
    public interface ICustomerOrderRepository
    {
        ICollection<CustomerOrderModel> GetAll();
        ICollection<CustomerOrderModel> GetByValue(string value);
        void Update(CustomerOrderModel model);
        void Add(CustomerOrderModel model);
    }
}
