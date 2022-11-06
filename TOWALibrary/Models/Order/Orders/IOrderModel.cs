using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TOWALibrary.Models.Account.Users;
using TOWALibrary.Models.Order.OrderDetails;

namespace TOWALibrary.Models.Order.Orders
{
    public interface IOrderModel
    {
        #region Display Attribute
        [DisplayName("Order ID")]
        string OID { get; set; }
        [DisplayName("Created By")]
        string CreatedByUID { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{dd/MM/yyyy}")]
        [DisplayName("Created By")]
        DateTime CreatedAt { get; set; }
        [DisplayName("Type")]
        string OrderTypeString { get; }
        [DisplayName("Payment")]
        string PaymentMethodString { get; }
        [DisplayName("Total")]
        float GrandTotal { get; set; }
        [DisplayName("Status")]
        string StatusString { get; }
        #endregion
        string Comments { get; set; }
      
        AccountModel CreatedBy { get; set; }
     
        ICollection<OrderDetailModel> OrderDetails { get; set; }
        int OrderType { get; set; }
        
        int PaymentMethod { get; set; }
      
        int Status { get; set; }
    
        float Total { get; set; }
        DateTime UpdatedAt { get; set; }
    }
}