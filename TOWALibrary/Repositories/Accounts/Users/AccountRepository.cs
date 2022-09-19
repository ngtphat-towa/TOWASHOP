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
using TOWALibrary.Repositories.Helpers;

namespace TOWALibrary.Repositories.Accounts.Users
{
    public class AccountRepository : IAccountRepository
    {
        public int LoginValidate(string username, string password)
        {
            int ouput = 0;

            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = @"dbo.spAccount_Login";
                    command.CommandType = CommandType.StoredProcedure;

                    command.CreateDbParameter("@USERNAME", DbType.String, username);
                    command.CreateDbParameter("@PASSWORD_HASH", DbType.String, password);
                    var returnValue = command.CreateDbParameter("@RID", DbType.Int32, 0, ParameterDirection.ReturnValue);
                    command.ExecuteNonQuery();

                    #region Account model code
                    //    if (reader.HasRows)
                    //    {
                    //        while (reader.Read())
                    //        {
                    //            model = new AccountModel();
                    //            var userid = reader.GetOrdinal("USERID");
                    //            model.UID = Convert.ToString(reader.GetString(userid));
                    //            model.Username = Convert.ToString(reader["USERNAME"]);
                    //            model.PasswordHash = Convert.ToString(reader["PASSWORD_HASH"]);
                    //            model.RegisterAt = Convert.ToDateTime(reader["REGISTER_AT"]);
                    //            model.RoleID = Convert.ToInt32(reader["ACCOUNT_RID"]);
                    //            model.LastLogin = DateTime.Now;
                    //            model.Role = roles.Where((r) => (r.RoleID == model.RoleID)).FirstOrDefault();
                    //        }
                    //    }
                    //    else return null;
                    //}
                    #endregion
                    ouput = Convert.ToInt32(returnValue.Value);



                };
                return ouput;
            }
        }
    }
}
