using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Account.Roles;
using TOWALibrary.Presenters.MainViews;
using TOWALibrary.Views.MainViews;

namespace TOWALibrary.Views
{
    public enum MainViewType
    {
        Admin,
        Employee
    }
    public static class MainViewNavigator
    {
        #region Static MainView
        private static IEmployeeView _employeeView ;
        private static IAdminView _adminView;
        #endregion

        #region Set up MainView
        public static void SetMainView(IAdminView adminView, IEmployeeView employeeView=null)
        {
            _adminView = adminView;
            _employeeView = employeeView;
        }

        private static IMainView mainView;
        public static IMainView GetMainView( this MainViewType role)
        {
            switch (role)
            {
                case MainViewType.Admin:
                    mainView= _adminView;
                    break;
                case MainViewType.Employee:
                    mainView= _employeeView;
                    break;
                default:
                    break;
            }
            return mainView;
        }
        #endregion
    }
}
