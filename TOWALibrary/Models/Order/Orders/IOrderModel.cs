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

        int OID { get; set; }

        string CreatedByUID { get; set; }

        DateTime CreatedAt { get; set; }

        string OrderTypeString { get; }
 
        string PaymentMethodString { get; }

        double GrandTotal { get; set; }

        string StatusString { get; }
        #endregion
        string Comments { get; set; }
      
        AccountModel CreatedBy { get; set; }
     
        ICollection<OrderDetailModel> OrderDetails { get; set; }
        int OrderType { get; set; }
        
        int PaymentMethod { get; set; }
      
        int Status { get; set; }
    
        double Total { get; set; }
        DateTime UpdatedAt { get; set; }
    }

}

