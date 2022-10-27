using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Contact.Customers;
using TOWALibrary.Models.Order.Orders;

namespace TOWALibrary.Models.Order.OrderType
{
   public class CustomerOrderModel: OrderModel
    {
        #region Constructor
        public CustomerOrderModel()
        {

        }
        #endregion

        #region Private Feilds
        private int _CO_ID;
        private string _CO_CTID;
        private CustomerModel customer;
        #endregion

        #region Display Attribute
        [DisplayName("CTID")]
        public string CO_CTID { get => _CO_CTID; set => _CO_CTID = value; }
        [DisplayName("Customer Name")]
        public string CustomerName { get => Customer.FullName; }
        #endregion

        #region Non-Display Attribute
        [Browsable(false)]
        public int CO_ID { get => _CO_ID; set => _CO_ID = value; }
        [Browsable(false)]
        public CustomerModel Customer { get => customer; set => customer = value; }
        #endregion

    }
}
