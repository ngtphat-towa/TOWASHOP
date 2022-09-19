using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Presenters;
using TOWALibrary.Repositories;
using TOWALibrary.Repositories.Accounts.Services;
using TOWALibrary.Repositories.Accounts.Users;
using TOWALibrary.Views;

namespace SimpleUITowaShop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #region Start with login form 
            DBManager.InitializeConnections(DataProvider.SQLServer);

            ILoginView loginView = LoginForm.Instance;
            IAuthenticationService authenticationService = new AuthenticationService();
            new LoginPresenter(loginView, authenticationService);

            MainViewNavigator.SetMainView(DashboardForm.Instance);

            Application.Run((Form)loginView);
            
            #endregion

            //  Application.Run(new DashboardForm());
        }

    }
}
