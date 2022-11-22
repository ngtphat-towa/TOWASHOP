using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Services.CommonServices;
using TOWALibrary.Services.ModelServices.UserServices;
using TOWALibrary.Views;
using TOWALibrary.Views.MainViews;

namespace TOWALibrary.Presenters
{
   public class LoginPresenter
    {
        #region Intialize private fields 
        private readonly ILoginView loginView;
        private readonly IAccountModelServices userService =ServicesManager.AccountModelServices;
        #endregion

        #region Contructor
        public LoginPresenter(ILoginView loginView)
        {
            this.loginView = loginView;
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
            try
            {

                    userService.Validate(this.loginView.Username, this.loginView.Password);
                    loginView.IsSuccessful = true;

                    GlobalConfig.CurrentUser = userService.GetAccountByUsername(loginView.Username);
                    this.loginView.Hide();
                     IMainView view = userService.GetRoleView();
                    view.Show();
                
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
