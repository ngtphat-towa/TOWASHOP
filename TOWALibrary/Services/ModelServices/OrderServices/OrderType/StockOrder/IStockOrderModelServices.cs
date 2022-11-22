using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Order.OrderType;
using TOWALibrary.Repositories.Order.SupplyOrders;

namespace TOWALibrary.Services.ModelServices.OrderServices.OrderType.StockOrder
{
   public interface IStockOrderModelServices:IStockOrderRepository
    {
        void ValidateModel(StockOrderModel model);
    }
}
