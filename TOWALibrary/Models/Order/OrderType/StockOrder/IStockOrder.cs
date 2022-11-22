using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Contact.Suppliers;

namespace TOWALibrary.Models.Order.OrderType
{
    public interface IStockOrder
    {
        int SO_ID { get; set; }
        string SO_SLID { get; set; }
        SupplierModel Supplier { get; set; }
    }
}
