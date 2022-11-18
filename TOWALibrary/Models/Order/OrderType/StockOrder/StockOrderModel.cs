using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Account.Users;
using TOWALibrary.Models.Contact.Customers;
using TOWALibrary.Models.Contact.Suppliers;
using TOWALibrary.Models.Order.Orders;

namespace TOWALibrary.Models.Order.OrderType
{
    public class StockOrderModel : OrderModel, IStockOrder
    {
        #region Constructor
        public StockOrderModel(){
               
         }
        #endregion
        #region Private Feilds
        private int _SO_ID;
        private string _SO_SLID;
        private SupplierModel supplier;

        #endregion

        #region Display Attribute
        [DisplayName("Supplier Name")]
        public string SupplierName { get => Supplier?.SupplierName; }
        #endregion
        #region Non-Display Attribute
        [Browsable(false)]
        public int SO_ID { get => _SO_ID; set => _SO_ID = value; }
        [Browsable(false)]
        public string SO_SLID { get => _SO_SLID; set => _SO_SLID = value; }
        [Browsable(false)]
        public SupplierModel Supplier { get => supplier; set => supplier = value; }

        #endregion
    }
}
