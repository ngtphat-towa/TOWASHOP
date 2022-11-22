using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Account.Users;
using TOWALibrary.Repositories;
using TOWALibrary.Repositories.Accounts.Users;
using TOWALibrary.Views;
using TOWALibrary.Views.MainViews;

namespace TOWALibrary.Services.ModelServices.UserServices
{
    public class AccountModelServices : IAccountModelServices
    {
        private int roleID;
       readonly IAccountRepository _accountRepository = DBManager.AccountRepository;

        public AccountModel GetAccountByUID(string UID)
        {
           return _accountRepository.GetAccountByUID(UID);
        }

        public AccountModel GetAccountByUsername(string username)
        {
            return _accountRepository.GetAccountByUsername(username);
        }

        public IMainView GetRoleView()
        {
            switch (roleID)
            {
                case 1:
                    return MainViewType.Admin.GetMainView();
                case 2:
                    return MainViewType.Employee.GetMainView();
                default:
                    return MainViewType.Employee.GetMainView();
            }

        }

        public bool Validate(string username, string password)
        {
            if (String.IsNullOrEmpty(username) && String.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Please enter the username and password");
            }

            // TODO - Improve this to have password hash
            AccountModel model = _accountRepository.GetAccountByUsername(username);
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
