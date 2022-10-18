﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Order.OrderDetails;
using TOWALibrary.Models.Order.Orders;
using TOWALibrary.Repositories.Accounts.Users;
using TOWALibrary.Repositories.Helpers;
using TOWALibrary.Repositories.Inventory.Products;
using TOWALibrary.Repositories.Order.OrderDetails;

namespace TOWALibrary.Repositories.Order.Orders
{
    public class OrderRepository : IOrderRepository
    {
 
        private readonly IOrderDetailRepository orderDetailRepository = DBManager.OrderDetailRepository;
        private readonly IAccountRepository accountRepository = DBManager.AccountRepository;

        public void Add(OrderModel model)
        {
            using (var connection = DBManager.Connection.GetDbConnection())
            {
                connection.Open();
                var dbTransaction = connection.BeginTransaction();
                try
                {
                    using (var command = DBManager.Connection.CreateNewCommand())
                    {
                        command.CommandText = "spOrder_Insert";
                        command.CommandType = CommandType.StoredProcedure;

                        command.CreateDbParameter("@CREATED_BY", DbType.String, model.CreatedBy.UID);
                        command.CreateDbParameter("@CREATED_AT", DbType.DateTime, model.CreatedAt);
                        command.CreateDbParameter("@UPDATED_AT", DbType.DateTime, model.UpdatedAt);
                        command.CreateDbParameter("@ORDER_TYPE", DbType.Int16, model.OrderType);
                        command.CreateDbParameter("@PAYMENT_METHOD", DbType.Int16, model.PaymentMethod);
                        command.CreateDbParameter("@TOTAL", DbType.Double, model.Total);
                        command.CreateDbParameter("@GRAND_TOTAL", DbType.Double, model.GrandTotal);
                        command.CreateDbParameter("@STATUS", DbType.Int16, model.Status);
                        command.CreateDbParameter("@COMMENTS", DbType.String, model.Comments);

                        command.ExecuteNonQuery();
                    }
                    foreach (var orderDetail in model.OrderDetails)
                    {
                        orderDetailRepository.Add(orderDetail);
                    }


                    dbTransaction.Commit();                  

                }
                catch (Exception ex)
                {
                    try
                    {
                        dbTransaction.Rollback();

                    }
                    catch (Exception exR)
                    {

                        throw new Exception(ex.Message+"\n"+ exR.Message);
                    }
                    
                }
            }
        }


        public ICollection<OrderModel> GetAll()
        {
            List<OrderModel> models = new List<OrderModel>();

            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "spOrder_GetAll";
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

                    }

                }
            }

            return models;
        }

        public ICollection<OrderModel> GetByValue(string value)
        {
            List<OrderModel> models = new List<OrderModel>();

            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "spOrder_GetByValue";
                    command.CommandType = CommandType.StoredProcedure;

                    command.CreateDbParameter("@VALUE", DbType.String, "%"+value.Trim()+"%");

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
                                Comments = Convert.ToString(reader["COMMENTS"]),
                                Status = Convert.ToInt32(reader["STATUS"])

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
                    }

                }
            }
            return models;
        }

        public void Update(OrderModel model)
        {
            using (var connection = DBManager.Connection.GetDbConnection())
            {
                connection.Open();
                var dbTransaction = connection.BeginTransaction();
                try
                {
                    using (var command = DBManager.Connection.CreateNewCommand())
                    {
                        command.CommandText = "spOrder_Update";
                        command.CommandType = CommandType.StoredProcedure;

                        command.CreateDbParameter("@CREATED_BY", DbType.String, model.OID);
                        command.CreateDbParameter("@CREATED_BY", DbType.String, model.CreatedBy.UID);
                        command.CreateDbParameter("@CREATED_AT", DbType.DateTime, model.CreatedAt);
                        command.CreateDbParameter("@UPDATED_AT", DbType.DateTime, model.UpdatedAt);
                        command.CreateDbParameter("@ORDER_TYPE", DbType.Int16, model.OrderType);
                        command.CreateDbParameter("@PAYMENT_METHOD", DbType.Int16, model.PaymentMethod);
                        command.CreateDbParameter("@TOTAL", DbType.Double, model.Total);
                        command.CreateDbParameter("@GRAND_TOTAL", DbType.Double, model.GrandTotal);
                        command.CreateDbParameter("@STATUS", DbType.Int16, model.Status);
                        command.CreateDbParameter("@COMMENTS", DbType.String, model.Comments);

                        command.ExecuteNonQuery();
                    }
                    foreach (var orderDetail in model.OrderDetails)
                    {
                        switch (orderDetail.Status)
                        {
                            case 0:
                                orderDetailRepository.Add(orderDetail);
                                break;
                            case 1:
                                orderDetailRepository.Update(orderDetail);
                                break;
                            case 2:
                                orderDetailRepository.Delete(orderDetail);
                                break;
                            default:
                                orderDetailRepository.Add(orderDetail);
                                break;
                        }
                    }


                    dbTransaction.Commit();

                }
                catch (Exception ex)
                {
                    try
                    {
                        dbTransaction.Rollback();

                    }
                    catch (Exception exR)
                    {

                        throw new Exception(ex.Message + "\n" + exR.Message);
                    }

                }
            }
        }
    }
}
