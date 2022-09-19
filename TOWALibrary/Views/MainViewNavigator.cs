using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Account.Roles;
using TOWALibrary.Views.MainViews;

namespace TOWALibrary.Views
{
    public enum MainViewType
    {
        Admin,
        Manager,
        Employee
    }
    public static class MainViewNavigator
    {
        #region Static MainView
        private static IAdminView adminView;
        private static  IManagerView managerView;
        private static IEmployeeView employeeView;
        private static IMainView mainView;
        #endregion

        #region Set up MainView
        public static void SetMainView(IAdminView _adminView, IEmployeeView _employeeView=null, IManagerView _managerView = null)
        {
            adminView = _adminView;
            managerView = _managerView;
            employeeView = _employeeView;
        }
        

        public static IMainView Navigate( this MainViewType role)
        {
            switch (role)
            {
                case MainViewType.Admin:
                    mainView= (IMainView)adminView ;
                    break;
                case MainViewType.Manager:
                    mainView=managerView as IMainView;
                    break;
                case MainViewType.Employee:
                    return employeeView as IMainView;
                default:
                    break;
            }
            return mainView;
        }
        #endregion
    }
}
