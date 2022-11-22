using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Inventory.Categoires;
using TOWALibrary.Repositories.Helpers;

namespace TOWALibrary.Repositories.Inventory.Categories
{
    public class CategoryRepository : ICategoryRepository
    {
        public void Add(CategoryModel model)
        {
            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "spCategory_Insert";
                    command.CommandType = CommandType.StoredProcedure;
                    command.CreateDbParameter("@CATEGORYNAME", DbType.String, model.CategoryName);
                    command.CreateDbParameter("@C_DESCRIPTION", DbType.String, model.Description);
                    command.CreateDbParameter("@CONTENT", DbType.String, model.Content);

                    command.ExecuteNonQuery();
                };
            };
        }


        public void Delete(int CID)
        {
            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "spCategory_Delete";
                    command.CommandType = CommandType.StoredProcedure;

                    command.CreateDbParameter("@CID", DbType.Int32, CID);

                    command.ExecuteNonQuery();
                }
            }
        }

        public virtual ICollection<CategoryModel> GetAll()
        {
            List<CategoryModel> models = new List<CategoryModel>();
            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "spCategory_GetAll";
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            models.Add(new CategoryModel
                            {
                                CATEID = Convert.ToInt32(reader["CATEGORYID"]),
                                CategoryName = Convert.ToString(reader["CATEGORYNAME"]),
                                Description = Convert.ToString(reader["C_DESCRIPTION"]),
                                Content = Convert.ToString(reader["CONTENT"])

                            });
                        }
                };
            };
            return models;
        }

        public virtual ICollection<CategoryModel> GetByValue(string value)
        {
            List<CategoryModel> models = new List<CategoryModel>();
            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "spCategory_GetByValue";
                    command.CommandType = CommandType.StoredProcedure;
                    command.CreateDbParameter("@VALUE", DbType.String,'%'+ value+'%');

                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            models.Add(new CategoryModel
                            {
                                CATEID = Convert.ToInt32(reader["CATEGORYID"]),
                                CategoryName = Convert.ToString(reader["CATEGORYNAME"]),
                                Description = Convert.ToString(reader["C_DESCRIPTION"]),
                                Content = Convert.ToString(reader["CONTENT"])

                            });
                        }
                };
            };
            return models;
        }

        public void Update(CategoryModel model)
        {
             using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "spCategory_Update";
                    command.CommandType = CommandType.StoredProcedure;

                    command.CreateDbParameter("@CID", DbType.String, model.CATEID);
                    command.CreateDbParameter("@CATEGORYNAME", DbType.String, model.CategoryName);
                    command.CreateDbParameter("@C_DESCRIPTION", DbType.String, model.Description);
                    command.CreateDbParameter("@CONTENT", DbType.String, model.Content);

                    command.ExecuteNonQuery();
                };
            };
        }
    }
}
