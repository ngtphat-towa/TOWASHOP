using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Order.OrderDetails;
using TOWALibrary.Models.Order.Orders;
using TOWALibrary.Repositories.Helpers;
using TOWALibrary.Repositories.Inventory.Products;
using TOWALibrary.Repositories.Order.OrderDetails;

namespace TOWALibrary.Repositories.Order.Orders
{
    public class OrderRepository : IOrderRepository
    {
 
        private readonly IOrderDetailRepository orderDetailRepository = DBManager.OrderDetailRepository;

        public OrderRepository()
        {

        }

        public void Add(OrderModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(OrderModel model)
        {
            throw new NotImplementedException();
        }

        public ICollection<OrderModel> GetAll()
        {
            List<OrderModel> models = new List<OrderModel>();

            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "dbo.spOrder_GetAll";
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OrderModel model = new OrderModel
                            {
                                OID = Convert.ToString(reader["ORDERID"]),
                                CreatedByUID = Convert.ToString(reader["CREATED_BY"]),
                                CreatedAt = Convert.ToDateTime(reader["CREATED_AT"]),
                                UpdatedAt = Convert.ToDateTime(reader["UPDATED_AT"]),
                                OrderType = Convert.ToInt32(reader["ORDER_TYPE"]),
                                PaymentMethod = Convert.ToInt32(reader["PAYMENT_METHOD"]),
                                Total = (float)Convert.ToDecimal(reader["TOTAL"]),
                                GrandTotal = (float)Convert.ToDecimal(reader["GRAND_TOTAL"]),
                                Comments = Convert.ToString(reader["STATUS"]),
                                Status = Convert.ToString(reader["COMMENTS"])

                            };
                            models.Add(model);
                        }
                    }
                    if (models.Count() == 0)
                        return models;
                    foreach (var m in models)
                    {
                        m.OrderDetails = orderDetailRepository.GetByOrder(m.OID);
                    }

                }
            }

            return models;
        }

        public ICollection<OrderModel> GetByValue()
        {
            throw new NotImplementedException();
        }

        public void Update(OrderModel model)
        {
            throw new NotImplementedException();
        }
    }
}
