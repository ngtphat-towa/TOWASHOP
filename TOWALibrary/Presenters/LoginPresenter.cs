using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Repositories.Accounts.Services;
using TOWALibrary.Views;

namespace TOWALibrary.Presenters
{
   public class LoginPresenter
    {
        #region Intialize private fields 
        private readonly ILoginView loginView;
        private readonly IAuthenticationService authenticationService;
        #endregion

        #region Contructor
        public LoginPresenter(ILoginView loginView, IAuthenticationService authenticationService)
        {
            this.loginView = loginView;
            this.authenticationService = authenticationService;
            // Wire up event handlers
            this.loginView.LoginAction += LoginEvent;
            this.loginView.CancelAction += delegate
             {
                 loginView.Username = "";
                 loginView.Password = "";
                 loginView.ErrorMessage = "";
             };
        }
        #endregion

        #region Wire up ILoginView
        private void LoginEvent(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(loginView.Username) || String.IsNullOrWhiteSpace(loginView.Password))
            {
                loginView.IsSuccessful = false;
                loginView.ErrorMessage = "Please enter the username and password";
                return;
            }
            try
            {
                bool authenticationResult = authenticationService.Validate(this.loginView.Username, this.loginView.Password);
                if (authenticationResult)
                {
                    loginView.IsSuccessful = true;
                    this.loginView.Hide();
                    authenticationService.GetRoleView().Navigate().Show();
                    
                }
                else
                {
                    loginView.ErrorMessage = "Username or password is incorrect!";
                }
            }
            catch (Exception ex)
            {
                loginView.IsSuccessful = false;
                loginView.ErrorMessage = ex.Message;

            }
        }
        #endregion
    }
}
