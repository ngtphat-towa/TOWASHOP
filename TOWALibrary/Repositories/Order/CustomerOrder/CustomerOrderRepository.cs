using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Order.Orders;
using TOWALibrary.Models.Order.OrderType;
using TOWALibrary.Repositories.Accounts.Users;
using TOWALibrary.Repositories.Contacts.Customers;
using TOWALibrary.Repositories.Helpers;
using TOWALibrary.Repositories.Order.OrderDetails;
using TOWALibrary.Repositories.Order.Orders;

namespace TOWALibrary.Repositories.Order.CustomerOrder
{
    public class CustomerOrderRepository : ICustomerOrderRepository
    {
        private readonly ICustomerRepository customerRepository = DBManager.CustomerRepository;
        private readonly IOrderRepository orderRepository = DBManager.OrderRepository;
        private readonly IOrderDetailRepository orderDetailRepository = DBManager.OrderDetailRepository;
        private readonly IAccountRepository accountRepository = DBManager.AccountRepository;
        public void Add(CustomerOrderModel model)
        {
            orderRepository.Add(model);
            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "spCustomerOrder_Insert";
                    command.CommandType = CommandType.StoredProcedure;

                    command.CreateDbParameter("@CO_CTID", DbType.String, model.CO_CTID);
                    command.CreateDbParameter("@CO_OID", DbType.String, model.OID);

                    command.ExecuteNonQuery();

                }
            }
        }

        public ICollection<CustomerOrderModel> GetAll()
        {
            List<CustomerOrderModel> models = new List<CustomerOrderModel>();

            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "spCustomerOrder_GetAll";
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CustomerOrderModel model = new CustomerOrderModel
                            {
                                CO_ID = Convert.ToInt32(reader["CO_CTID"]),
                                CO_CTID = Convert.ToString(reader["CO_CTID"]),
                                OID = Convert.ToString(reader["ORDERID"]),
                                CreatedByUID = Convert.ToString(reader["CREATED_BY"]),
                                CreatedAt = Convert.ToDateTime(reader["CREATED_AT"]),
                                UpdatedAt = Convert.ToDateTime(reader["UPDATED_AT"]),
                                OrderType = Convert.ToInt32(reader["ORDER_TYPE"]),
                                PaymentMethod = Convert.ToInt32(reader["PAYMENT_METHOD"]),
                                Total = (float)Convert.ToDecimal(reader["TOTAL"]),
                                GrandTotal = (float)Convert.ToDecimal(reader["GRAND_TOTAL"]),
                                Status = Convert.ToInt32(reader["STATUS"]),
                                Comments = Convert.ToString(reader["COMMENTS"])

                            };
                            models.Add(model);
                        }
                    }
                    if (models.Count() == 0)
                        return models;
                    foreach (var m in models)
                    {
                        m.OrderDetails = orderDetailRepository.GetByOrder(m.OID);
                        m.CreatedBy = accountRepository.GetAccountByUID(m.CreatedByUID);
                        m.Customer = customerRepository.GetByValue(m.CO_CTID).FirstOrDefault();
                    }
                }
            }

            return models;

        }

        public ICollection<CustomerOrderModel> GetByValue(string value)
        {
            List<CustomerOrderModel> models = new List<CustomerOrderModel>();

            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "spCustomerOrder_GetByValue";
                    command.CommandType = CommandType.StoredProcedure;

                    command.CreateDbParameter("@VALUE", DbType.String, "%" + value.Trim() + "%");

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CustomerOrderModel model = new CustomerOrderModel
                            {
                                CO_ID = Convert.ToInt32(reader["CO_CTID"]),
                                CO_CTID = Convert.ToString(reader["CO_CTID"]),
                                OID = Convert.ToString(reader["ORDERID"]),
                                CreatedByUID = Convert.ToString(reader["CREATED_BY"]),
                                CreatedAt = Convert.ToDateTime(reader["CREATED_AT"]),
                                UpdatedAt = Convert.ToDateTime(reader["UPDATED_AT"]),
                                OrderType = Convert.ToInt32(reader["ORDER_TYPE"]),
                                PaymentMethod = Convert.ToInt32(reader["PAYMENT_METHOD"]),
                                Total = (float)Convert.ToDecimal(reader["TOTAL"]),
                                GrandTotal = (float)Convert.ToDecimal(reader["GRAND_TOTAL"]),
                                Status = Convert.ToInt32(reader["STATUS"]),
                                Comments = Convert.ToString(reader["COMMENTS"])

                            };
                            models.Add(model);
                        }
                    }
                    if (models.Count() == 0)
                        return models;
                    foreach (var m in models)
                    {
                        m.OrderDetails = orderDetailRepository.GetByOrder(m.OID);
                        m.CreatedBy = accountRepository.GetAccountByUID(m.CreatedByUID);
                        m.Customer = customerRepository.GetByValue(m.CO_CTID).FirstOrDefault();
                    }

                }
            }

            return models;
        }

        public void Update(CustomerOrderModel model)
        {
            orderRepository.Update(model);
            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "spCustomerOrder_Update";
                    command.CommandType = CommandType.StoredProcedure;

                    command.CreateDbParameter("@CO_ID", DbType.Int32, model.CO_ID);
                    command.CreateDbParameter("@CO_CTID", DbType.String, model.CO_CTID);
                    command.CreateDbParameter("@CO_OID", DbType.String, model.OID);

                    command.ExecuteNonQuery();

                }
            }
        }
    }
}
