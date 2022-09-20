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
        Manager,
        Employee
    }
    public static class MainViewNavigator
    {
        #region Static MainView
        private static  IManagerView managerView;
        private static IEmployeeView employeeView;
        private static IAdminView adminView;
        #endregion

        #region Set up MainView
        public static void SetMainView(IAdminView _adminView, IEmployeeView _employeeView=null, IManagerView _managerView = null)
        {
            adminView = _adminView;
            managerView = _managerView;
            employeeView = _employeeView;
        }
        

        public static void Navigate( this MainViewType role)
        {
            switch (role)
            {
                case MainViewType.Admin:
                   new AdminPresenter(adminView);
                    break;
                case MainViewType.Manager:
                    
                    break;
                case MainViewType.Employee:
                 
                default:
                    break;
            }
            
        }
        #endregion
    }
}
