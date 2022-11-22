using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Order.OrderDetails;
using TOWALibrary.Models.Order.Orders;

namespace TOWALibrary.Repositories.Order.OrderDetails
{
  public interface IOrderDetailRepository
    {
        ICollection<OrderDetailModel> GetByOrder(int OID);
        void Update(OrderDetailModel model);
        void Add(OrderDetailModel model);
        void Delete(OrderDetailModel model);
        OrderDetailModel GetByID(int OD_ID);
    }
}
