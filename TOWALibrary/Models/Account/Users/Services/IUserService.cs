using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Account.Roles;
using TOWALibrary.Models.Account.Users;
using TOWALibrary.Views;

namespace TOWALibrary.Models.Accounts.Users.Services
{
    public interface IUserService
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
