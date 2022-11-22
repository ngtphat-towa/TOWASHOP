using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Contact.Customers;

namespace TOWALibrary.Models.Order.OrderType
{
   public interface ICustomerOrder
    {
        int CO_ID { get; set; }
        string CO_CTID { get; set; }
        CustomerModel Customer { get; set; }
    }
}
