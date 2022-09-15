using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOWALibrary.Views
{
    public interface ILoginView
    {
        string Username { get; set; }
        string Password { get; set; }
        string ErrorMessage { get; set; }
        bool IsSuccessful { get; set; }
        event EventHandler LoginAction;
        event EventHandler CancelAction;
        void Hide();
    }
}
