using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Inventory.Products;
using TOWALibrary.Models.Order.Orders;

namespace TOWALibrary.Models.Order.OrderDetails
{
  public  class OrderDetailModel
    {
        #region Private Fields
        private string _OD_OID;
        private string _OD_PID;
        private string quantity;
        private float   unitPrice;
        private float discount;

        #endregion
        #region Property
        public string OD_OID { get => _OD_OID; set => _OD_OID = value; }
        public string OD_PID { get => _OD_PID; set => _OD_PID = value; }
        public string Quantity { get => quantity; set => quantity = value; }
        public float UnitPrice { get => unitPrice; set => unitPrice = value; }
        public float Discount { get => discount; set => discount = value; }
        #endregion
    }
}
