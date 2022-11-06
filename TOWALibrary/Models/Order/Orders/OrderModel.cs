using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Account.Users;
using TOWALibrary.Models.Order.OrderDetails;

namespace TOWALibrary.Models.Order.Orders
{

    public class OrderModel : IOrderModel
    {
        #region Private Fields
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
        private int status;
        private string comments;
        private DateTime updatedAt;
        #endregion
        #region Property

        #region Display Attribute
        [DisplayName("Order ID")]
        public string OID { get => _OID; set => _OID = value; }
        [DisplayName("Created By")]
        public string CreatedByUID { get => _CreatedByUID; set => _CreatedByUID = value; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [DisplayName("Created By")]
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        [DisplayName("Type")]
        public string OrderTypeString { get => OrderType.OrderTypeString(); }
        [DisplayName("Payment")]
        public string PaymentMethodString { get => PaymentMethod.PaymentMethodString(); }
        [DisplayName("Total")]
        public float GrandTotal { get => grandTotal; set => grandTotal = value; }
        [DisplayName("Status")]
        public string StatusString { get => Status.OrderStatusString(); }
        #endregion

        #region Non-Display Attribute
        [Browsable(false)]
        public AccountModel CreatedBy { get => createdBy; set => createdBy = value; }
        [Browsable(false)]
        public int OrderType { get => _OrderType; set => _OrderType = value; }
        [Browsable(false)]
        public int PaymentMethod { get => _paymentMethod; set => _paymentMethod = value; }
        [Browsable(false)]
        public float Total { get => total; set => total = value; }

        [Browsable(false)]
        public string Comments { get => comments; set => comments = value; }
        [Browsable(false)]
        public int Status { get => status; set => status = value; }
        [Browsable(false)]
        public DateTime UpdatedAt { get => updatedAt; set => updatedAt = value; }
        [Browsable(false)]
        public ICollection<OrderDetailModel> OrderDetails { get; set; }
        #endregion


        #endregion
    }
}
