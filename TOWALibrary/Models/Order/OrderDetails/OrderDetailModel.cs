﻿using System;
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
        private int _OD_ID;
        private string _OD_OID;
        private string _OD_PID;
       private  ProductModel product;
        private int quantity;
        private float   unitPrice;
        private float discount;

        #endregion
        #region Property
        public int OD_ID { get => _OD_ID; set => _OD_ID = value; }
        public string OD_OID { get => _OD_OID; set => _OD_OID = value; }
        public string OD_PID { get => _OD_PID; set => _OD_PID = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public float UnitPrice { get => unitPrice; set => unitPrice = value; }
        public float Discount { get => discount; set => discount = value; }
         public ProductModel Product { get => product; set => product = value; }
        #endregion
    }
}
