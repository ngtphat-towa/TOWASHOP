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
        public virtual ICollection<RoleViewModel> GetRole_All()
        {
            List<RoleViewModel> models = new List<RoleViewModel>();
            using (var connection = DBManager.Connection.GetDbConnection())
            {

                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = "spAccountRole_GetAll";
                    command.CommandType = CommandType.StoredProcedure;
                    var reader = command.ExecuteReader();
                    while (reader.Read()) {
                        models.Add(new RoleViewModel
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
