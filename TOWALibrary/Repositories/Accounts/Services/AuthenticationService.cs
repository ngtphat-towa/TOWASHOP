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
    public class AuthenticationService : IAuthenticationService
    {
       private RoleModel roleModel;
        public MainViewType GetMainViewType()
        {
            
            switch (roleModel.RoleID)
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
            bool result = true;
            IAccountRepository repository = new AccountRepository();
            // TODO - Improve this
            AccountModel  model =repository.GetAccount(username, password);
            if (model == null) return false;
            roleModel = model.Role;
            return result;
        }
    }
}
