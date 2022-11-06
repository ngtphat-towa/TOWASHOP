using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Views.ModuleViews.Orders.OrderDetails;

namespace TOWALibrary.Presenters.Modules.Orders.OrderDetails
{
    public class OrderFormPresenter
    {
        private readonly IOrderFormView view;
        public OrderFormPresenter(IOrderFormView view)
        {
            
            this.view = view;
            this.view.OrderTypeChangedEvent += OrderTypeChangedEvent;
        }

        private void OrderTypeChangedEvent(object sender, EventArgs e)
        {
            switch (this.view.OrderType)
            {
                case 1:
                    this.view.SetOrderInfoControl(this.view.CustomerOrderInfoControl);
                    break;
                case 2:
                    this.view.SetOrderInfoControl(this.view.SupplierOrderInfoControl);
                    break;
                default:
                    break;
            }
        }
    }
}
