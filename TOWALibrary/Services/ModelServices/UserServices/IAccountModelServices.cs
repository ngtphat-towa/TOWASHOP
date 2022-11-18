using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Repositories.Accounts.Users;
using TOWALibrary.Views;

namespace TOWALibrary.Services.ModelServices.UserServices
{
    public interface IAccountModelServices: IAccountRepository
    {
        /// <summary>
        /// Take the user and the password to validate the login
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool Validate(string username, string password);
        /// <summary>
        /// Using role for the view authenitcation 
        /// </summary>
        /// <returns></returns>
        MainViewType GetRoleView();
    }
}
