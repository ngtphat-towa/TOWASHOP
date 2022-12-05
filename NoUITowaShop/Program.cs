using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Presenters;
using TOWALibrary.Presenters.MainViews;
using TOWALibrary.Repositories;
using TOWALibrary.Models.Accounts.Users.Services;
using TOWALibrary.Repositories.Accounts.Users;
using TOWALibrary.Views;
using TOWALibrary.Views.MainViews;
using NoUITowaShop.ModelListForm;
using TOWALibrary.Services.CommonServices;
using TOWALibrary.Services.ModelServices.UserServices;
using NoUITowaShop;

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

            // Remember changing this
            DBManager.InitializeConnections(DataProvider.MySQL);

            #region Start with login form 

            ILoginView loginView = LoginForm.Instance;

            Application.Run((Form)loginView);

            #endregion

            //StartWithDashboard();
            //StartWithForm();
        }

        private static void StartWithDashboard()
        {
            DBManager.InitializeConnections(DataProvider.SQLServer);

            IAdminView view = DashboardForm.Instance;

            GlobalConfig.CurrentUser = new AccountModelServices().GetAccountByUsername("admin");

            MainViewNavigator.SetMainView(DashboardForm.Instance, CashierForm.Instance);

            Application.Run((Form)view);
        }
        private static void StartWithForm()
        {
            //DBManager.InitializeConnections(DataProvider.SQLServer);
            //Application.Run(new ProductListForm(t));
        }

    }
}
