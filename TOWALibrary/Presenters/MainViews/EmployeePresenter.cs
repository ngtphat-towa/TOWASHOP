using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Views.MainViews;

namespace TOWALibrary.Presenters.MainViews
{
    public class EmployeePresenter
    {
        private IEmployeeView _view;

        public EmployeePresenter(IEmployeeView view)
        {
            _view = view;
            _view.ShowOrderListModuleView += ShowOrderListModuleView;
            _view.ShowOrderFormView += ShowOrderFormView;
            _view.ShowCustomerModuleView += ShowCustomerModuleView;
            _view.LogoutEvent += LogoutEvent;
        }
        private void LogoutEvent(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you want to log out ?", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                _view.Close();
                _view.GetLoginView.GetNewLogin();
            }

        }
        private void ShowOrderListModuleView(object sender, EventArgs e)
        {
            _view.OrderListModuleView.Show();
        }
        private void ShowCustomerModuleView(object sender, EventArgs e)
        {
            _view.CustomerModuleView.Show();
        }

        private void ShowOrderFormView(object sender, EventArgs e)
        {
            _view.OrderFormView.Show();
        }

    }
}
