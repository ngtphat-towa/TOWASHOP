using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Order.OrderType;
using TOWALibrary.Repositories.Order.CustomerOrder;

namespace TOWALibrary.Services.ModelServices.OrderServices.OrderType.CustomerOrder
{
   public interface ICustomerOrderModelServices: ICustomerOrderRepository
    {
        void ValidateModel(CustomerOrderModel model);
    }
}
