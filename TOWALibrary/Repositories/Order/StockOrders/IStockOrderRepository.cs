using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Order.OrderType;

namespace TOWALibrary.Repositories.Order.SupplyOrders
{
    public interface IStockOrderRepository
    {
        ICollection<StockOrderModel> GetAll();
        void Update(StockOrderModel model);
        void Add(StockOrderModel model);
        ICollection<StockOrderModel> GetByValue(string value );


    }
}
