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

        #region Display Attribute

        [DisplayName("#Supplier ID")]
        public string SLID { get => _SLID; set => _SLID = value; }

        [DisplayName("Name")]
        [Required( ErrorMessage = "Supplier name is required")]
        [StringLength(30, ErrorMessage = "The maximum length of the supplier name is 30 characters!")]
        public string SupplierName { get => supplierName; set => supplierName = value; }
       
        [DisplayName("Contact Person")]
        [StringLength(30, ErrorMessage = "The maximum length of the contact name is 30 characters!")]
        public string ContactName { get => contactName; set => contactName = value; }

        [DisplayName("Contact Phone")]
        [Required( ErrorMessage = "Contact name is required")]
        [StringLength(30, ErrorMessage = "The maximum length of the supplier name is 30 characters!")]
        
        public string ContactPhone { get => contactPhone; set => contactPhone = value; }
        [DisplayName("Address")]
        public string FullAddress => String.Join(", ", Address, City, Country);

        [DisplayName("Comment")]
        [StringLength(255, ErrorMessage = "The maximum length of the comment is 255 characters!")]
        public string Content { get => content; set => content = value; }
        #endregion

        #region Non-Display Attribute

        [Browsable(false)]
        [StringLength(50, ErrorMessage = "The maximum length of the address is 50 characters!")]
        public string Address { get => address; set => address = value; }

        [Browsable(false)]
        [StringLength(20, ErrorMessage = "The maximum length of the city name is 20 characters!")]
        public string City { get => city; set => city = value; }

        [Browsable(false)]
        [StringLength(20, ErrorMessage = "The maximum length of the country name is 20 characters!")]
        public string Country { get => country; set => country = value; }


        [Browsable(false)]
        public virtual ICollection<ProductModel> Products { get; set; }

        #endregion

        #endregion
    }
}
