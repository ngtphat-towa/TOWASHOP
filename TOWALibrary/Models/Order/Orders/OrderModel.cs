using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Account.Users;

namespace TOWALibrary.Models.Order.Orders
{
    public class OrderModel
    {
        #region Privat Fields
        // Intail info
        private string _OID;
        private string _customerID;
        private AccountModel createdBy;
        private DateTime createdAt;
        // Order type info
        private int _OrderType;
        private int _paymentMethod;
        // General info
        private float totalItems;
        private float grandTotal;
        private float discount;
        // meta
        private string status;
        private string comments;
        #endregion
        #region Property
        public string OID { get => _OID; set => _OID = value; }
        public string CustomerID { get => _customerID; set => _customerID = value; }
        public AccountModel CreatedBy { get => createdBy; set => createdBy = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public int OrderType { get => _OrderType; set => _OrderType = value; }
        public int PaymentMethod { get => _paymentMethod; set => _paymentMethod = value; }
        public float TotalItems { get => totalItems; set => totalItems = value; }
        public float GrandTotal { get => grandTotal; set => grandTotal = value; }
        public float Discount { get => discount; set => discount = value; }
        public string Status { get => status; set => status = value; }
        public string Comments { get => comments; set => comments = value; }
        #endregion
    }
}
