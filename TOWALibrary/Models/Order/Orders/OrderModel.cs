using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Account.Users;
using TOWALibrary.Models.Order.OrderDetails;

namespace TOWALibrary.Models.Order.Orders
{
    public class OrderModel
    {
        #region Privat Fields
        // Intail info
        private string _OID;
        private string _CreatedByUID;
        private AccountModel createdBy;
        private DateTime createdAt;
        // Order type info
        private int _OrderType;
        private int _paymentMethod;
        // General info
        private float total;
        private float grandTotal;
        
        // meta
        private string status;
        private string comments;
        private DateTime updatedAt;
        #endregion
        #region Property
        public string OID { get => _OID; set => _OID = value; }
        public AccountModel CreatedBy { get => createdBy; set => createdBy = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public int OrderType { get => _OrderType; set => _OrderType = value; }
        public int PaymentMethod { get => _paymentMethod; set => _paymentMethod = value; }
        public float Total { get => total; set => total = value; }
        public float GrandTotal { get => grandTotal; set => grandTotal = value; }

        public string Status { get => status; set => status = value; }
        public string Comments { get => comments; set => comments = value; }
        public string CreatedByUID { get => _CreatedByUID; set => _CreatedByUID = value; }
        public DateTime UpdatedAt { get => updatedAt; set => updatedAt = value; }
        public ICollection<OrderDetailModel> OrderDetails { get; set; }
        #endregion
    }
}
