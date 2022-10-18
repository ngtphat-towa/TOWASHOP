using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        private string city;
        private string country;
        private string content;
        
        #endregion
        #region Property
        [DisplayName("SLID")]
        [Column(Order = 1)]
        public string SLID { get => _SLID; set => _SLID = value; }
        public string SupplierName { get => supplierName; set => supplierName = value; }
        public string ContactName { get => contactName; set => contactName = value; }
        public string ContactPhone { get => contactPhone; set => contactPhone = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }

        public string Content { get => content; set => content = value; }
        [Browsable(false)]
        public virtual ICollection<ProductModel> Products { get; set; }
        [DisplayName("Product")]
        public string ProductIDList
        {
            get
            {
                if (Products == null || this.Products.ToList().Count == 0)
                    return "";
                return string.Join(",", Products.Select(p => p.PID).ToArray());
            }
        }
        #endregion
    }
}
