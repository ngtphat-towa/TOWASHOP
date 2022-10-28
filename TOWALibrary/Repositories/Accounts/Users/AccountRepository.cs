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
        public AccountModel GetAccountByUID(string UID)
        {
            List<AccountModel> models = new List<AccountModel>();

            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = @"dbo.spAccount_GetByUID";
                    command.CommandType = CommandType.StoredProcedure;

                    command.CreateDbParameter("@UID", DbType.String, UID);
                    var reader = command.ExecuteReader();

                    #region Account model code
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            models.Add(new AccountModel
                            {
                                UID = Convert.ToString(reader.GetString(reader.GetOrdinal("USERID"))),
                                Username = Convert.ToString(reader["USERNAME"]),
                                RegisterAt = Convert.ToDateTime(reader["REGISTER_AT"]),
                                RoleID = Convert.ToInt32(reader["RID"]),
                                LastLogin = Convert.ToDateTime(reader["LAST_LOGIN"]),
                                Role = new RoleViewModel
                                {
                                    RoleID = Convert.ToInt32(reader["RID"]),
                                    RoleName = Convert.ToString(reader["ROLENAME"]),
                                    Discription = Convert.ToString(reader["R_DESCRIPTION"])

                                }
                            });
                        }
                    }
                }
                #endregion
            };

            return models.FirstOrDefault();
        }

        public AccountModel GetAccountByUsername(string username)
        {
            List<AccountModel> models = new List<AccountModel>();

            using (var connection = DBManager.Connection.GetDbConnection())
            {
                using (var command = DBManager.Connection.CreateNewCommand())
                {
                    connection.Open();
                    command.CommandText = @"dbo.spAccount_GetByUsername";
                    command.CommandType = CommandType.StoredProcedure;

                    command.CreateDbParameter("@USERNAME", DbType.String, username);
                    var reader = command.ExecuteReader();

                    #region Account model code
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            models.Add(new AccountModel
                            {
                                UID = Convert.ToString(reader.GetString(reader.GetOrdinal("USERID"))),
                                Username = Convert.ToString(reader["USERNAME"]),
                                PasswordHash = Convert.ToString(reader["PASSWORD_HASH"]),
                                RegisterAt = Convert.ToDateTime(reader["REGISTER_AT"]),
                                RoleID = Convert.ToInt32(reader["RID"]),
                                LastLogin = Convert.ToDateTime(reader["LAST_LOGIN"]),
                                Role = new RoleViewModel
                                {
                                    RoleID = Convert.ToInt32(reader["RID"]),
                                    RoleName = Convert.ToString(reader["ROLENAME"]),
                                    Discription = Convert.ToString(reader["R_DESCRIPTION"])

                                }
                            });
                        }
                    }
                }
                #endregion
            };

            return models.FirstOrDefault();
        }
    }
}

