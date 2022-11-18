using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Order.Orders;
using TOWALibrary.Models.Order.OrderType;
using TOWALibrary.Repositories;
using TOWALibrary.Repositories.Order.SupplyOrders;
using TOWALibrary.Services.CommonServices;
using TOWALibrary.Services.ModelServices.OrderServices.OrderType.Order;

namespace TOWALibrary.Services.ModelServices.OrderServices.OrderType.StockOrder
{
    public class StockOrderModelServices : IStockOrderModelServices
    {
        readonly IStockOrderRepository _stockOrderRepository = DBManager.StockOrderRepository;
        public void Add(StockOrderModel model)
        {
            _stockOrderRepository.Add(model);
        }

        public ICollection<StockOrderModel> GetAll()
        {
          return  _stockOrderRepository.GetAll();
        }

        public ICollection<StockOrderModel> GetByValue(string value)
        {
            return _stockOrderRepository.GetByValue(value);
        }

        public void Update(StockOrderModel model)
        {
            _stockOrderRepository.Update(model);
        }

        public void ValidateModel(StockOrderModel model)
        {
            ModelDataValidationCheck.Validate(model);
        }
    }
}
