using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Account.Roles;

namespace TOWALibrary.Repositories.Accounts.Roles
{
    public class RoleRepository : IRoleRepository
    {
        public IEnumerable<RoleModel> GetRole_All()
        {
            List<RoleModel> models = new List<RoleModel>();
            using (var connection = DBManager.Connection.GetDbConnection())
            {

                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "dbo.AccountRole_GetAll";
                    command.CommandType = CommandType.StoredProcedure;
                    var reader = command.ExecuteReader();
                    while (reader.Read()) {
                        models.Add(new RoleModel
                        {
                            RoleID = Convert.ToInt32(reader["ROLEID"]),
                            RoleName = Convert.ToString(reader["ROLENAME"]),
                            Discription = Convert.ToString(reader["R_DESCRIPTION"])
                        });
                    }
                    
                }

                
            };
            return models;
        }
    }
}
