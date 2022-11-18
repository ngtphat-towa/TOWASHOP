using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Contact.Customers;
using TOWALibrary.Repositories.Helpers;

namespace TOWALibrary.Repositories.Contacts.Customers
{
    // TODO - implement this 
    public class CustomerRepository : ICustomerRepository
    {
        public void Add(CustomerModel model)
        {
            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "dbo.spCustomer_Insert";
                    command.CommandType = CommandType.StoredProcedure;

                    command.CreateDbParameter("@CID", DbType.String, model.CID);
                    command.CreateDbParameter("@FIRST_NAME", DbType.String, model.FirstName);
                    command.CreateDbParameter("@LAST_NAME", DbType.String, model.LastName);
                    command.CreateDbParameter("@CONTACT_PHONE", DbType.String, model.ContactPhone);
                    command.CreateDbParameter("@SL_ADDRESS", DbType.String, model.Address);
                    command.CreateDbParameter("@CITY", DbType.String, model.City);
                    command.CreateDbParameter("@COUNTRY", DbType.String, model.Country);
                    command.CreateDbParameter("@CONTENT", DbType.String, model.Content);

                    command.ExecuteNonQuery();
                };
            };
        }
        public void Delete(string CTID)
        {
            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "dbo.spCustomer_Delete";
                    command.CommandType = CommandType.StoredProcedure;

                    command.CreateDbParameter("@CUSTOMERID", DbType.String, CTID);

                    command.ExecuteNonQuery();
                }
            }
        }

        public ICollection<CustomerModel> GetAll()
        {
            List<CustomerModel> models = new List<CustomerModel>();
            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "dbo.spCustomer_GetAll";
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            models.Add(new CustomerModel
                            {
                                CTID = Convert.ToString(reader["CUSTOMERID"]),
                                CID = Convert.ToString(reader["CID"]),
                                FirstName = Convert.ToString(reader["FIRST_NAME"]),
                                LastName = Convert.ToString(reader["LAST_NAME"]),
                                ContactPhone = Convert.ToString(reader["CONTACT_PHONE"]),
                                Address = Convert.ToString(reader["SL_ADDRESS"]),
                                City = Convert.ToString(reader["CITY"]),
                                Country = Convert.ToString(reader["COUNTRY"]),
                                Content = Convert.ToString(reader["CONTENT"])
                            });
                        }
                };
            };
            return models;
        }

        public ICollection<CustomerModel> GetByValue(string value)
        {
            List<CustomerModel> models = new List<CustomerModel>();
            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "dbo.spCustomer_GetByValue";
                    command.CommandType = CommandType.StoredProcedure;

                    command.CreateDbParameter("@SEARCHVALUE", DbType.String, value.Trim()  );

                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            models.Add(new CustomerModel
                            {
                                CTID = Convert.ToString(reader["CUSTOMERID"]),
                                CID = Convert.ToString(reader["CID"]),
                                FirstName = Convert.ToString(reader["FIRST_NAME"]),
                                LastName = Convert.ToString(reader["LAST_NAME"]),
                                ContactPhone = Convert.ToString(reader["CONTACT_PHONE"]),
                                Address = Convert.ToString(reader["SL_ADDRESS"]),
                                City = Convert.ToString(reader["CITY"]),
                                Country = Convert.ToString(reader["COUNTRY"]),
                                Content = Convert.ToString(reader["CONTENT"])
                            });
                        }
                };
            };
            return models;
        }

        public void Update(CustomerModel model)
        {
            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "dbo.spCustomer_Update";
                    command.CommandType = CommandType.StoredProcedure;

                    command.CreateDbParameter("@CUSTOMERID", DbType.String, model.CTID);
                    command.CreateDbParameter("@CID", DbType.String, model.CID);
                    command.CreateDbParameter("@FIRST_NAME", DbType.String, model.FirstName);
                    command.CreateDbParameter("@LAST_NAME", DbType.String, model.LastName);
                    command.CreateDbParameter("@CONTACT_PHONE", DbType.String, model.ContactPhone);
                    command.CreateDbParameter("@SL_ADDRESS", DbType.String, model.Address);
                    command.CreateDbParameter("@CITY", DbType.String, model.City);
                    command.CreateDbParameter("@COUNTRY", DbType.String, model.Country);
                    command.CreateDbParameter("@CONTENT", DbType.String, model.Content);

                    command.ExecuteNonQuery();
                };
            };
        }
    }
}
