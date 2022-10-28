using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Inventory.Products;
using TOWALibrary.Models.Order.OrderDetails;
using TOWALibrary.Models.Order.Orders;
using TOWALibrary.Repositories.Helpers;
using TOWALibrary.Repositories.Inventory.Products;

namespace TOWALibrary.Repositories.Order.OrderDetails
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly IProductRepository productRepository = DBManager.ProductRepository;
        

        public void Add(OrderDetailModel model)
        {
            using (var command = DBManager.Connection.CreateNewCommand())
                {
                    command.CommandText = "spOrderDetails_Insert";
                    command.CommandType = CommandType.StoredProcedure;

                    command.CreateDbParameter("@OD_OID", DbType.String, model.OD_OID);
                    command.CreateDbParameter("@OD_PID", DbType.String, model.OD_PID);
                    command.CreateDbParameter("@UNIT_PRICE", DbType.String, model.UnitPrice);
                    command.CreateDbParameter("@QUANTITY", DbType.String, model.Quantity);
                    command.CreateDbParameter("@DISCOUNT", DbType.String, model.Discount);

                    command.ExecuteNonQuery();
                };
        }

        public void Delete(OrderDetailModel model)
        {

            using (var command = DBManager.Connection.CreateNewCommand())
            {
                command.CommandText = "spOrderDetails_Delete";
                command.CommandType = CommandType.StoredProcedure;

                command.CreateDbParameter("@OD_ID", DbType.String, model.OD_ID);

                command.ExecuteNonQuery();

            }
        }

        public ICollection<OrderDetailModel> GetByOrder(string OID)
        {
            List<OrderDetailModel> models = new List<OrderDetailModel>();


            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "spOrderDetails_GetByOrder";
                    command.CommandType = CommandType.StoredProcedure;

                    command.CreateDbParameter("@OD_OID", DbType.String, OID);
                    using (var reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            OrderDetailModel model = new OrderDetailModel
                            {
                                OD_ID = Convert.ToInt32(reader["OD_ID"]),
                                OD_OID = Convert.ToString(reader["OD_OID"]),
                                OD_PID = Convert.ToString(reader["OD_PID"]),
                                Quantity = Convert.ToInt32(reader["QUANTITY"]),
                                UnitPrice = (float)Convert.ToDouble(reader["UNIT_PRICE"]),
                                Discount = (float)Convert.ToDouble(reader["DISCOUNT"])

                            };
                            model.Product = productRepository.GetByValue(model.OD_PID).FirstOrDefault();
                            models.Add(model);
                        }
                    }
                }
            }
            return models;

        }

        public OrderDetailModel GetByID(int OD_ID)
        {
            List<OrderDetailModel> models = new List<OrderDetailModel>();
            using (var command = DBManager.Connection.CreateNewCommand())
            {

                command.CommandText = "spOrderDetails_GetByID";
                command.CommandType = CommandType.StoredProcedure;

                command.CreateDbParameter("@OD_ID", DbType.String, OD_ID);
                using (var reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        OrderDetailModel model = new OrderDetailModel
                        {
                            OD_ID = Convert.ToInt32(reader["OD_ID"]),
                            OD_OID = Convert.ToString(reader["OD_OID"]),
                            OD_PID = Convert.ToString(reader["OD_PID"]),
                            Quantity = Convert.ToInt32(reader["QUANTITY"]),
                            UnitPrice = (float)Convert.ToDouble(reader["UNIT_PRICE"]),
                            Discount = (float)Convert.ToDouble(reader["DISCOUNT"])
                        };
                        model.Product = productRepository.GetByValue(model.OD_PID).FirstOrDefault();
                        models.Add(model);
                    }
                }
            }
            return models.FirstOrDefault();
        }
        public void Update(OrderDetailModel model)
        {
            using (var command = DBManager.Connection.CreateNewCommand())
            {
                command.CommandText = "spOrderDetails_Insert";
                command.CommandType = CommandType.StoredProcedure;

                command.CreateDbParameter("@OD_OID", DbType.String, model.OD_OID);
                command.CreateDbParameter("@OD_PID", DbType.String, model.OD_PID);
                command.CreateDbParameter("@UNIT_PRICE", DbType.String, model.UnitPrice);
                command.CreateDbParameter("@QUANTITY", DbType.String, model.Quantity);
                command.CreateDbParameter("@DISCOUNT", DbType.String, model.Discount);

                command.ExecuteNonQuery();
            };

        }
    }
}
