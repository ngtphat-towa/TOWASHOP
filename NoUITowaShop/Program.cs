using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Presenters;
using TOWALibrary.Presenters.MainViews;
using TOWALibrary.Repositories;
using TOWALibrary.Repositories.Accounts.Services;
using TOWALibrary.Repositories.Accounts.Users;
using TOWALibrary.Views;
using TOWALibrary.Views.MainViews;

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
            //DBManager.InitializeConnections(DataProvider.SQLServer);

            //ILoginView loginView = LoginForm.Instance;
            //IUserService userService = new UserServie();
            //new LoginPresenter(loginView, userService);

            //MainViewNavigator.SetMainView(DashboardForm.Instance);

            //Application.Run((Form)loginView);

            #endregion

            StartWithDashboard();
        }

        private static void StartWithDashboard()
        {
            DBManager.InitializeConnections(DataProvider.SQLServer);

            IAdminView view = DashboardForm.Instance;

            new AdminPresenter(view);

            MainViewNavigator.SetMainView(DashboardForm.Instance);

            Application.Run((Form)view);
        }

    }
}
