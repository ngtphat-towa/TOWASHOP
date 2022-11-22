using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOWALibrary.Views.MainViews
{
    public interface IMainView
    {
       event EventHandler LogoutEvent;
        void Show();
    }
}
