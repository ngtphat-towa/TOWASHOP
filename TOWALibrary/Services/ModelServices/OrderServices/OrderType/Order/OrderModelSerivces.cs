using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Order.Orders;
using TOWALibrary.Repositories;
using TOWALibrary.Repositories.Order.Orders;
using TOWALibrary.Services.CommonServices;

namespace TOWALibrary.Services.ModelServices.OrderServices.OrderType.Order
{
    public class OrderModelServices : IOrderModelServices
    {
        readonly IOrderRepository _orderRepository = DBManager.OrderRepository;
        public void Add(OrderModel model)
        {
            _orderRepository.Add(model);
        }

        public ICollection<OrderModel> GetAll()
        {
            return _orderRepository.GetAll();
        }

        public ICollection<OrderModel> GetByValue(string value)
        {
            return _orderRepository.GetByValue(value);
        }

        public void Update(OrderModel oldModel,OrderModel model)
        {
            _orderRepository.Update(oldModel,model);
        }

        public void ValidateModel(OrderModel model)
        {
            ModelDataValidationCheck.Validate(model);
        }
    }
}
