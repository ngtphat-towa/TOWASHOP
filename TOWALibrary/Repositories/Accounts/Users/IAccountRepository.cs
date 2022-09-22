using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Account.Users;

namespace TOWALibrary.Repositories.Accounts.Users
{
   public interface IAccountRepository 
    {
        AccountModel GetAccountByUsername(string username);
    }
}
