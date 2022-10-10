using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Models.Order.Orders;
using TOWALibrary.Repositories.Order.Orders;
using TOWALibrary.Views.ModuleViews.Orders;

namespace TOWALibrary.Presenters.Modules.Orders
{
   public class OrderListMoudlePresenter
    {
        private readonly IOrderListMoudleView view;
        private readonly IOrderRepository repository;
        private ICollection<OrderModel> orderList;
        private readonly BindingSource orderListBindingSource;
        private BindingSource orderDetailListBindingSource;

        public OrderListMoudlePresenter(IOrderListMoudleView view, IOrderRepository repository)
        {
            this.view = view;
            this.repository = repository;
            this.orderListBindingSource = new BindingSource();
            this.orderDetailListBindingSource = new BindingSource();
            //Wire up event handler methods to view events
            this.view.ShowBillReviewByOrderEvent += ShowBillReviewByOrder;
            this.view.SearchEvent += SearchOrder;
            this.view.AddNewEvent += AddNewOrder;
            this.view.EditEvent += LoadSelectedOrderToEdit;
            this.view.DeleteEvent += DeleteSelectedOrder;
            this.view.SaveEvent += SaveOrder;
            this.view.CancelEvent += CancelAction;
            //Set binding source
            this.view.SetOrderListViewBindingSource(orderListBindingSource);
            this.view.SetOrderDetailsListViewBindingSource(orderDetailListBindingSource);
            LoadAllOrderList();
            //Show view
            this.view.Show();
        }

        private void LoadAllOrderList()
        {
            orderList = repository.GetAll();
            orderListBindingSource.DataSource = orderList;
               
        }

        private void CancelAction(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveOrder(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedOrder(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedOrderToEdit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewOrder(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchOrder(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ShowBillReviewByOrder(object sender, EventArgs e)
        {
            OrderModel model = (OrderModel)orderListBindingSource.Current;
            this.orderDetailListBindingSource.DataSource = model.OrderDetails;
        }
    }
}
