using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOWALibrary.Models.Order.Orders
{
   public static class OrderFormatHelper
    {
        private static readonly string[] OrderType = new string[] { "Retail Order", "Customer Order", "Supply Stock" };
        private static readonly string[] PaymentMethod = new string[] { "Cash", "Credit" };
        private static readonly string[] Status = new string[] { "New", "Paid", "Delivering" };
        public static string OrderTypeString(this int OrderTypeNumber)
        {
               return OrderType[OrderTypeNumber];
        }
        public static string PaymentMethodString(this int PaymentMethodNumber)
        {
            return PaymentMethod[PaymentMethodNumber];
        }
        public static string OrderStatusString(this int OrderStatusNumber)
        {
            return Status[OrderStatusNumber];
        }
    }
}
