using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Inventory.Products;

namespace TOWALibrary.Models.Contact.Suppliers
{
    public class SupplierModel
    {
        #region Private Feilds
        // Supplier Inforamtion
        private string _SLID;
        private string supplierName;
        // Suplier Contact
        private string contactName;
        private string contactPhone;
        private string address;
        private string country;

        #endregion
        #region Property
        public string SLID { get => _SLID; set => _SLID = value; }
        public string SupplierName { get => supplierName; set => supplierName = value; }
        public string ContactName { get => contactName; set => contactName = value; }
        public string ContactPhone { get => contactPhone; set => contactPhone = value; }
        public string Address { get => address; set => address = value; }
        public string Country { get => country; set => country = value; }
        public IEnumerable<ProductModel> Products { get; set; }
        #endregion

    }
}
