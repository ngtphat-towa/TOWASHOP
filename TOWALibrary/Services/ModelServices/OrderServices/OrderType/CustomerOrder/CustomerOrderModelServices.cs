using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Order.OrderType;
using TOWALibrary.Repositories;
using TOWALibrary.Repositories.Order.CustomerOrder;

namespace TOWALibrary.Services.ModelServices.OrderServices.OrderType.CustomerOrder
{
    public class CustomerOrderModelServices : ICustomerOrderModelServices
    {
        ICustomerOrderRepository _customerOrderRepository = DBManager.CustomerOrderRepository;
        public void Add(CustomerOrderModel model)
        {
            _customerOrderRepository.Add(model);
        }

        public ICollection<CustomerOrderModel> GetAll()
        {
            return _customerOrderRepository.GetAll();
        }

        public ICollection<CustomerOrderModel> GetByValue(string value)
        {
            return _customerOrderRepository.GetByValue(value);
        }

        public void Update(CustomerOrderModel oldModel, CustomerOrderModel model)
        {
            _customerOrderRepository.Update(oldModel,model);
        }

        public void ValidateModel(CustomerOrderModel model)
        {
            CommonServices.ModelDataValidationCheck.Validate(model);
        }
    }
}
