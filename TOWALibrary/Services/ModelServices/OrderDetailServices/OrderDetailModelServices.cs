using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Order.OrderDetails;
using TOWALibrary.Repositories;
using TOWALibrary.Repositories.Order.OrderDetails;

namespace TOWALibrary.Services.ModelServices.OrderDetailServices
{
    public class OrderDetailModelServices : IOrderDetailModelServices
    {
        IOrderDetailRepository _orderDetailRepository = DBManager.OrderDetailRepository;
        public void Add(OrderDetailModel model)
        {
            _orderDetailRepository.Add(model);
        }

        public void Delete(OrderDetailModel model)
        {
            _orderDetailRepository.Delete(model);
        }

        public OrderDetailModel GetByID(int OD_ID)
        {
           return _orderDetailRepository.GetByID(OD_ID);
        }

        public ICollection<OrderDetailModel> GetByOrder(int OID)
        {
            return _orderDetailRepository.GetByOrder(OID);
        }

        public void Update(OrderDetailModel model)
        {
            _orderDetailRepository.Update(model);
        }

        public double GetGrandTotal(List<OrderDetailModel> models)
        {
            double output =0;
            if (models.Count >0)
                output = models.Sum(item => item.Quantity * item.Product.SalesPrice * (1 - item.Discount / 100));
            return output;
        }

        public double GetTotalCost(List<OrderDetailModel> models)
        {
            double output = 0;
            if (models.Count > 0)
                output = models.Sum(item => item.Quantity * item.Product.SalesPrice);
            return output;
        }

        public double GetTotalDiscount(List<OrderDetailModel> models)
        {
            double output = 0;
            if (models.Count > 0)
            {
                double cal = 1;
                foreach (var item in models)
                {
                    cal *=( 1 - item.Discount/100);
                }
                output =( 1 - cal)*100;
            }

            return output ;
        }

  

        public void ValidateModel(OrderDetailModel model)
        {
            CommonServices.ModelDataValidationCheck.Validate(model);
        }

    
    }
}
