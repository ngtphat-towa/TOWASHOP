using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Account.Roles;
using TOWALibrary.Models.Account.Users;
using TOWALibrary.Repositories.Accounts.Users;
using TOWALibrary.Views;

namespace TOWALibrary.Repositories.Accounts.Services
{
    public class UserServie : IUserService
    {
       private int roleID;
        public MainViewType GetRoleView()
        {
            switch (roleID)
            {
                case 1:
                    return MainViewType.Admin;
                    
                case 2:
                    return MainViewType.Manager;
                case 3:
                    return MainViewType.Employee;
                default:
                    return MainViewType.Employee;
            }
            
        }

        public bool Validate(string username, string password)
        {
            if (String.IsNullOrEmpty(username) && String.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Please enter the username and password");
            }

            IAccountRepository repository = new AccountRepository();
            // TODO - Improve this to have password hash
            AccountModel  model =repository.GetAccountByUsername(username);
            bool result;
            if (model != null)
            {
                if (model.PasswordHash.Equals(password))
                {
                    result = true;
                    roleID = model.RoleID;
                }
                else
                {
                    throw new Exception("Username or password is incorrect");
                }
            }
            else
            {
                throw new Exception("The input username does not exits!");
            }
            return result;
        }
    }
}
