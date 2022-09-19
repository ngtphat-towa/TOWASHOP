using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Contact.Suppliers;
using TOWALibrary.Repositories.Helpers;
namespace TOWALibrary.Repositories.Contacts.Suppliers
{
    public class SupplierRepository : ISupplierRepository
    {
        public void Add(SupplierModel model)
        {
            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "dbo.spSupplier_Insert";
                    command.CommandType = CommandType.StoredProcedure;

                    command.CreateDbParameter("@SUPPLIER_NAME", DbType.String, model.SupplierName);
                    command.CreateDbParameter("@CONTACT_NAME", DbType.String, model.ContactName);
                    command.CreateDbParameter("@CONTACT_PHONE", DbType.String, model.ContactPhone);
                    command.CreateDbParameter("@ADDRESS", DbType.String, model.Address);
                    command.CreateDbParameter("@CITY", DbType.String, model.City);
                    command.CreateDbParameter("@COUNTRY", DbType.String, model.Country);

                    command.ExecuteNonQuery();
                };
            };
        }

        public void Delete(SupplierModel model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SupplierModel> GetAll()
        {
            List<SupplierModel> models = new List<SupplierModel>();
            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "dbo.spSupplier_GetAll";
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            models.Add(new SupplierModel
                            {
                                SLID = Convert.ToString(reader["SUPPLIERID"]),
                                SupplierName = Convert.ToString(reader["SUPPLIER_NAME"]),
                                ContactName = Convert.ToString(reader["CONTACT_NAME"]),
                                ContactPhone = Convert.ToString(reader["CONTACT_PHONE"]),
                                Address = Convert.ToString(reader["ADDRESS"]),
                                City = Convert.ToString(reader["CITY"]),
                                Country = Convert.ToString(reader["COUNTRY"]),

                            });
                        }
                };
            };
            return models;
        }

        public IEnumerable<SupplierModel> GetByValue(string value)
        {
            List<SupplierModel> models = new List<SupplierModel>();
            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "dbo.spSupplier_GetByValue";
                    command.CommandType = CommandType.StoredProcedure;

                    command.CreateDbParameter("@SEARCHVALUE", DbType.String, value);

                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            models.Add(new SupplierModel
                            {
                                SLID = Convert.ToString(reader["SUPPLIERID"]),
                                SupplierName = Convert.ToString(reader["SUPPLIER_NAME"]),
                                ContactName = Convert.ToString(reader["CONTACT_NAME"]),
                                ContactPhone = Convert.ToString(reader["CONTACT_PHONE"]),
                                Address = Convert.ToString(reader["ADDRESS"]),
                                City = Convert.ToString(reader["CITY"]),
                                Country = Convert.ToString(reader["COUNTRY"]),

                            });
                        }
                };
            };
            return models;
        }

        public void Update(SupplierModel model)
        {
            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "dbo.spSupplier_";
                    command.CommandType = CommandType.StoredProcedure;

                    command.CreateDbParameter("@SUPPLIER_NAME", DbType.String, model.SupplierName);
                    command.CreateDbParameter("@CONTACT_NAME", DbType.String, model.ContactName);
                    command.CreateDbParameter("@CONTACT_PHONE", DbType.String, model.ContactPhone);
                    command.CreateDbParameter("@ADDRESS", DbType.String, model.Address);
                    command.CreateDbParameter("@CITY", DbType.String, model.City);
                    command.CreateDbParameter("@COUNTRY", DbType.String, model.Country);

                    command.ExecuteNonQuery();
                };
            };
        }
    }
}
