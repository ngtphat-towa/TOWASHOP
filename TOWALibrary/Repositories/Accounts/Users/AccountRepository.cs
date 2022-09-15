using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Account.Roles;
using TOWALibrary.Models.Account.Users;
using TOWALibrary.Repositories.Accounts.Roles;

namespace TOWALibrary.Repositories.Accounts.Users
{
    public class AccountRepository : IAccountRepository
    {
        public AccountModel GetAccount(string username, string password)
        {
            AccountModel model = new AccountModel();
            List<RoleModel> roles = (List<RoleModel>)new RoleRepository().GetRole_All();
            using (var connection = DBManager.Connection.GetDbConnection())
            {            
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText= @"SELECT * from DBO.ACCOUNTS WHERE USERNAME = @username";
             
                    DbParameter p = command.CreateParameter();
                    p.ParameterName = "@username";
                    p.Value = username;
                    p.DbType = DbType.String;
                    command.Parameters.Add(p);

                    var reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            model = new AccountModel();
                            var userid = reader.GetOrdinal("USERID");
                            model.UID = Convert.ToString(reader.GetString(userid));
                            model.Username = Convert.ToString(reader["USERNAME"]);
                            model.PasswordHash = Convert.ToString(reader["PASSWORD_HASH"]);
                            model.RegisterAt = Convert.ToDateTime(reader["REGISTER_AT"]);
                            model.RoleID = Convert.ToInt32(reader["ACCOUNT_RID"]);
                            model.LastLogin = DateTime.Now;


                            model.Role = roles.Where((r) => (r.RoleID == model.RoleID)).FirstOrDefault();
                        }
                    }
                    else return null;
                }
               
            };
            return model;
        }
    }
}
