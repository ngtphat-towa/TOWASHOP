﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Order.OrderType;
using TOWALibrary.Repositories.Accounts.Users;
using TOWALibrary.Repositories.Contacts.Suppliers;
using TOWALibrary.Repositories.Helpers;
using TOWALibrary.Repositories.Inventory.Products;
using TOWALibrary.Repositories.Order.OrderDetails;

namespace TOWALibrary.Repositories.Order.SupplyOrders
{
    // TODO- Implement this sir
    public class StockOrderRepository : IStockOrderRepository
    {
        private readonly IOrderDetailRepository orderDetailRepository = DBManager.OrderDetailRepository;
        private readonly IAccountRepository accountRepository = DBManager.AccountRepository;
        private readonly IProductRepository productRepository = DBManager.ProductRepository;
        private readonly ISupplierRepository supplierRepository = DBManager.SupplierRepository;
        public void Add(StockOrderModel model)
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
                        productRepository.UpdateProductStock(orderDetail.OD_PID, 0, orderDetail.Quantity);
                        orderDetailRepository.Add(orderDetail);
                    }
                    using (var command = DBManager.Connection.CreateNewCommand())
                    {
                        connection.Open();
                        command.CommandText = "spStockOrder_Insert";
                        command.CommandType = CommandType.StoredProcedure;

                        command.CreateDbParameter("@SO_SLID", DbType.String, model.SO_SLID);
                        command.CreateDbParameter("@CO_OID", DbType.String, model.OID);

                        command.ExecuteNonQuery();

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


        public ICollection<StockOrderModel> GetAll()
        {
            List<StockOrderModel> models = new List<StockOrderModel>();

            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "spStockOrder_GetAll";
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StockOrderModel model = new StockOrderModel();

                            model.SO_ID = Convert.ToInt32(reader["SO_ID"]);
                            model.SO_SLID = Convert.ToString(reader["SO_SLID"]);
                            model.OID = Convert.ToString(reader["ORDERID"]);
                            model.CreatedByUID = Convert.ToString(reader["CREATED_BY"]);
                            model.CreatedAt = Convert.ToDateTime(reader["CREATED_AT"]);
                            model.UpdatedAt = Convert.ToDateTime(reader["UPDATED_AT"]);
                            model.OrderType = Convert.ToInt32(reader["ORDER_TYPE"]);
                            model.PaymentMethod = Convert.ToInt32(reader["PAYMENT_METHOD"]);
                            model.Total = (float)Convert.ToDecimal(reader["TOTAL"]);
                            model.GrandTotal = (float)Convert.ToDecimal(reader["GRAND_TOTAL"]);
                            model.Status = Convert.ToInt32(reader["STATUS"]);
                            model.Comments = Convert.ToString(reader["COMMENTS"]);


                            models.Add(model);
                        }
                    }
                    if (models.Count() == 0)
                        return models;
                    foreach (var m in models)
                    {
                        m.OrderDetails = orderDetailRepository.GetByOrder(m.OID);
                        m.CreatedBy = accountRepository.GetAccountByUID(m.CreatedByUID);
                        m.Supplier = supplierRepository.GetByValue(m.SO_SLID).FirstOrDefault();
                    }
                }
            }

            return models;
        }

        public void Update(StockOrderModel model)
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
                    };
                    foreach (var orderDetail in model.OrderDetails)
                    {
                        var oldModel = orderDetailRepository.GetByID(orderDetail.OD_ID);
                        switch (orderDetail.Status)
                        {
                            case 0:
                                productRepository.UpdateProductStock(orderDetail.OD_PID, 0, orderDetail.Quantity);

                                orderDetailRepository.Add(orderDetail);
                                break;
                            case 1:
                                productRepository.UpdateProductStock(orderDetail.OD_OID, oldModel.Quantity, orderDetail.Quantity);

                                orderDetailRepository.Update(orderDetail);
                                break;
                            case 2:
                                productRepository.UpdateProductStock(orderDetail.OD_PID, oldModel.Quantity, 0);

                                orderDetailRepository.Delete(orderDetail);
                                break;
                            default:
                                break;
                        }
                    }

                    using (var command = DBManager.Connection.CreateNewCommand())
                    {
                        connection.Open();
                        command.CommandText = "spStockOrder_Update";
                        command.CommandType = CommandType.StoredProcedure;

                        command.CreateDbParameter("@SO_ID", DbType.Int32, model.SO_ID);
                        command.CreateDbParameter("@SO_SLID", DbType.String, model.SO_SLID);
                        command.CreateDbParameter("@SO_OID", DbType.String, model.OID);

                        command.ExecuteNonQuery();

                    };
                    

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

        public ICollection<StockOrderModel> GetByValue(string value)
        {
            List<StockOrderModel> models = new List<StockOrderModel>();

            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "spStockOrder_GetByValue";
                    command.CommandType = CommandType.StoredProcedure;

                    command.CreateDbParameter("@VALUE", DbType.String, "%" + value.Trim() + "%");

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StockOrderModel model = new StockOrderModel();

                            model.SO_ID = Convert.ToInt32(reader["SO_ID"]);
                            model.SO_SLID = Convert.ToString(reader["SO_SLID"]);
                            model.OID = Convert.ToString(reader["ORDERID"]);
                            model.CreatedByUID = Convert.ToString(reader["CREATED_BY"]);
                            model.CreatedAt = Convert.ToDateTime(reader["CREATED_AT"]);
                            model.UpdatedAt = Convert.ToDateTime(reader["UPDATED_AT"]);
                            model.OrderType = Convert.ToInt32(reader["ORDER_TYPE"]);
                            model.PaymentMethod = Convert.ToInt32(reader["PAYMENT_METHOD"]);
                            model.Total = (float)Convert.ToDecimal(reader["TOTAL"]);
                            model.GrandTotal = (float)Convert.ToDecimal(reader["GRAND_TOTAL"]);
                            model.Status = Convert.ToInt32(reader["STATUS"]);
                            model.Comments = Convert.ToString(reader["COMMENTS"]);


                            models.Add(model);
                        }
                    }
                    if (models.Count() == 0)
                        return models;
                    foreach (var m in models)
                    {
                        m.OrderDetails = orderDetailRepository.GetByOrder(m.OID);
                        m.CreatedBy = accountRepository.GetAccountByUID(m.CreatedByUID);
                        m.Supplier = supplierRepository.GetByValue(m.SO_SLID).FirstOrDefault();
                    }
                }
            }

            return models;
        }
    }
}