using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Inventory.Products;
using TOWALibrary.Models.Order.Orders;

namespace TOWALibrary.Models.Order.OrderDetails
{
    public enum OrderDetailStatus
    {
        New, Modify, Remove, Load
    }
    public class OrderDetailModel
    {
        #region Private Fields
        private int _OD_ID;
        private int _OD_OID;
        private string _OD_PID;
        private ProductModel product;
        private int quantity;
        private double unitPrice;
        private double discount;

        #endregion
        #region Property
        #region Display Attribute
        [DisplayName("Product Name")]
        public string ProductName { get => Product.ProductName; }
        [DisplayName("Unit")]
        public int Quantity { get => quantity; set => quantity = value; }
        [DisplayName("Product Unit")]
        public string ProductUnit { get => Product.QuantityPerUnit; }
        [DisplayName("Price")]
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
        [DisplayName("Discount %")]
        public double Discount { get => discount; set => discount = value; }
        #endregion

        #region Non-Display Attribute
        [Browsable(false)]
        public int OD_ID { get => _OD_ID; set => _OD_ID = value; }

        [Browsable(false)]
        public int OD_OID { get => _OD_OID; set => _OD_OID = value; }

        [Browsable(false)]
        public string OD_PID { get => _OD_PID; set => _OD_PID = value; }

        [Browsable(false)]
        public ProductModel Product { get => product; set => product = value; }

        [Browsable(false)]
        public OrderDetailStatus Status { get; set; }
        #endregion

        #endregion
    }
}
