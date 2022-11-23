using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOWALibrary.Views.MainViews
{
    public interface IMainView
    {
        bool IsLogout { get; set; }
       event EventHandler LogoutEvent;
        ILoginView GetLoginView { get; }
        void Show();
        void Close();
    }
}
