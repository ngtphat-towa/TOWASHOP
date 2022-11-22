using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Order.OrderDetails;
using TOWALibrary.Repositories.Order.OrderDetails;

namespace TOWALibrary.Services.ModelServices.OrderDetailServices
{
    public interface IOrderDetailModelServices : IOrderDetailRepository
    {
        void ValidateModel(OrderDetailModel model);
        double GetTotalCost(List<OrderDetailModel> models);
       // double GetTotalDiscount(List<OrderDetailModel> models);
        double GetGrandTotal(List<OrderDetailModel> models);
    }
}
