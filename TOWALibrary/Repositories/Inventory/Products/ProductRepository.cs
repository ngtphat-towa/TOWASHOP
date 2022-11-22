using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Contact.Suppliers;
using TOWALibrary.Models.Inventory.Categoires;
using TOWALibrary.Models.Inventory.Products;
using TOWALibrary.Repositories.Contacts.Suppliers;
using TOWALibrary.Repositories.Helpers;
using TOWALibrary.Repositories.Inventory.Categories;

namespace TOWALibrary.Repositories.Inventory.Products
{
    public class ProductRepository : IProductRepository
    {
       private readonly ISupplierRepository supplierRepository = DBManager.SupplierRepository;
        private readonly ICategoryRepository categoryRepository =DBManager.CategoryRepository;


        public void Add(ProductModel model)
        {
            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "spProduct_Insert";
                    command.CommandType = CommandType.StoredProcedure;

                    command.CreateDbParameter("@PRODUCTNAME", DbType.String, model.ProductName);
                    command.CreateDbParameter("@BARCODE", DbType.String, model.Barcode);
                    command.CreateDbParameter("@QUANTITY_PER_UNIT", DbType.String, model.QuantityPerUnit);
                    command.CreateDbParameter("@UNIT_PRICE", DbType.Double, model.UnitPrice);
                    command.CreateDbParameter("@SALES_PRICE", DbType.Double, model.SalesPrice);
                    command.CreateDbParameter("@UNIT_ON_STOCK", DbType.Int32, model.UnitOnStock);
                    command.CreateDbParameter("@UNIT_ON_ORDER", DbType.Int32, model.UnitOnOrder);
                    command.CreateDbParameter("@VAT", DbType.Double, model.VAT);
                    command.CreateDbParameter("@STATUS", DbType.String, model.Status);
                    command.CreateDbParameter("@PC_CATEID", DbType.Int32, model.Category.CATEID);
                    command.CreateDbParameter("@PS_SLID", DbType.String, model.Supplier.SLID);

                    command.ExecuteNonQuery();

                }
            }
        }


        public void Delete(string PID)
        {
            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "spProduct_Delete";
                    command.CommandType = CommandType.StoredProcedure;

                    command.CreateDbParameter("@PID", DbType.String, PID);
                    
                    command.ExecuteNonQuery();

                }
            }
        }

        public virtual ICollection<ProductModel> GetAll()
        {
            ICollection<ProductModel> models = new List<ProductModel>();
            ICollection<SupplierModel> suppliers = supplierRepository.GetAll();
            ICollection<CategoryModel> categories =categoryRepository.GetAll();

            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "spProduct_GetAll";
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                    {
                        
                        while (reader.Read())
                        {
                            ProductModel model=  new ProductModel
                            {
                                PID = Convert.ToString(reader["PRODUCTID"]),
                                ProductName = Convert.ToString(reader["PRODUCTNAME"]),
                                Barcode = Convert.ToString(reader["BARCODE"]),
                                QuantityPerUnit = Convert.ToString(reader["QUANTITY_PER_UNIT"]),
                                UnitPrice = Convert.ToDouble(reader["UNIT_PRICE"]),
                                SalesPrice = Convert.ToDouble(reader["SALES_PRICE"]),
                                UnitOnStock = Convert.ToInt16(reader["UNIT_ON_STOCK"]),
                                UnitOnOrder = Convert.ToInt16(reader["UNIT_ON_ORDER"]),
                                VAT = Convert.ToDouble(reader["VAT"]),
                                Status = Convert.ToString(reader["STATUS"]),
                                Content = Convert.ToString(reader["CONTENT"])
                                
                            };
                            int CID = Convert.ToInt32(reader["PC_CATEID"]);
                            model.Category = categories.Where(c => c.CATEID == CID).FirstOrDefault();
                            string SID = Convert.ToString(reader["PS_SLID"]);
                            model.Supplier = suppliers.Where(c => c.SLID.Equals(SID)).FirstOrDefault();
                           // add new model
                            models.Add(model);
                        }
                    };

                };
            };
            return models;
        }


        public virtual ICollection<ProductModel> GetByValue(string value)
        {
            ICollection<ProductModel> models = new List<ProductModel>();
            ICollection<SupplierModel> suppliers = supplierRepository.GetAll();
            ICollection<CategoryModel> categories = categoryRepository.GetAll();

            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "spProduct_GetByValue";
                    command.CommandType = CommandType.StoredProcedure;

                    command.CreateDbParameter("@VALUE", DbType.String, "%"+ value.Trim() + "%");

                    using (var reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            ProductModel model = new ProductModel
                            {
                                PID = Convert.ToString(reader["PRODUCTID"]),
                                ProductName = Convert.ToString(reader["PRODUCTNAME"]),
                                Barcode = Convert.ToString(reader["BARCODE"]),
                                QuantityPerUnit = Convert.ToString(reader["QUANTITY_PER_UNIT"]),
                                UnitPrice = Convert.ToDouble(reader["UNIT_PRICE"]),
                                SalesPrice = Convert.ToDouble(reader["SALES_PRICE"]),
                                UnitOnStock = Convert.ToInt16(reader["UNIT_ON_STOCK"]),
                                UnitOnOrder = Convert.ToInt16(reader["UNIT_ON_ORDER"]),
                                VAT = Convert.ToDouble(reader["VAT"]),
                                Status = Convert.ToString(reader["STATUS"]),
                                Content = Convert.ToString(reader["CONTENT"]),

                            };
                            int CID = Convert.ToInt32(reader["PC_CATEID"]);
                            model.Category = categories.Where(c => c.CATEID == CID).FirstOrDefault();
                            string SID = Convert.ToString(reader["PS_SLID"]);
                            model.Supplier = suppliers.Where(c => c.SLID.Equals(SID)).FirstOrDefault();
                            // add new model
                            models.Add(model);
                        }
                    };

                };
            };
            return models;
        }

        public ICollection<CategoryModel> GetCategories()
        {
            return categoryRepository.GetAll();
        }

        public ICollection<SupplierModel> GetSupliers()
        {
            return supplierRepository.GetAll();
        }

        public void Update(ProductModel model)
        {
            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "spProduct_Update";
                    command.CommandType = CommandType.StoredProcedure;

                    command.CreateDbParameter("@PRODUCTID", DbType.String, model.PID);
                    command.CreateDbParameter("@PRODUCTNAME", DbType.String, model.ProductName);
                    command.CreateDbParameter("@BARCODE", DbType.String, model.Barcode);
                    command.CreateDbParameter("@QUANTITY_PER_UNIT", DbType.String, model.QuantityPerUnit);
                    command.CreateDbParameter("@UNIT_PRICE", DbType.Double, model.UnitPrice);
                    command.CreateDbParameter("@SALES_PRICE", DbType.Double, model.SalesPrice);
                    command.CreateDbParameter("@UNIT_ON_STOCK", DbType.Int32, model.UnitOnStock);
                    command.CreateDbParameter("@UNIT_ON_ORDER", DbType.Int32, model.UnitOnOrder);
                    command.CreateDbParameter("@VAT", DbType.Double, model.VAT);
                    command.CreateDbParameter("@STATUS", DbType.String, model.Status);
                    command.CreateDbParameter("@PC_CATEID", DbType.Int32, model.Category.CATEID);
                    command.CreateDbParameter("@PS_SLID", DbType.String, model.Supplier.SLID);
                    command.CreateDbParameter("@CONTENT", DbType.String, model.Content);

                    command.ExecuteNonQuery();

                }
            }
        }

        public void UpdateProductOrder(string PID, int oldQuanity, int newQuantity)
        {
            using (var command = DBManager.Connection.CreateNewCommand())
            {
                command.CommandText = "spProduct_UpdateProductOrder";
                command.CommandType = CommandType.StoredProcedure;

                command.CreateDbParameter("@OD_PID", DbType.String, PID);
                command.CreateDbParameter("@OLD_QUANTITY", DbType.String, oldQuanity);
                command.CreateDbParameter("@NEW_QUANTITY", DbType.String, newQuantity);

                command.ExecuteNonQuery();

            };
        }

        public void UpdateProductStock(string PID, int oldQuanity, int newQuantity)
        {
            using (var command = DBManager.Connection.CreateNewCommand())
            {
                command.CommandText = "spProduct_UpdateProductStock";
                command.CommandType = CommandType.StoredProcedure;

                command.CreateDbParameter("@OD_PID", DbType.String, PID);
                command.CreateDbParameter("@OLD_QUANTITY", DbType.String, oldQuanity);
                command.CreateDbParameter("@NEW_QUANTITY", DbType.String, newQuantity);

                command.ExecuteNonQuery();

            };
        }
    }
}
