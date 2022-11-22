using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
