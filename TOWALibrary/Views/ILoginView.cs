using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Views.MainViews;

namespace TOWALibrary.Views
{
    public interface ILoginView
    {
        string Username { get; set; }
        string Password { get; set; }
        string ErrorMessage { get; set; }
        bool IsSuccessful { get; set; }
        void GetNewLogin();
        event EventHandler LoginAction;
        event EventHandler LogoutAction;
        event EventHandler CancelAction;

        IAdminView AdminView { get; }
        IEmployeeView EmployeeView { get; }
        void Show();
        void Hide();
    }
}
