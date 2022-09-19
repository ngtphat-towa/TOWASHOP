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
       private int RID;
        public MainViewType GetRoleView()
        {
            
            switch (RID)
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
            int  validResult =repository.LoginValidate(username, password);
            result = (validResult != 0);
            this.RID = validResult;
            return result;
        }
    }
}
