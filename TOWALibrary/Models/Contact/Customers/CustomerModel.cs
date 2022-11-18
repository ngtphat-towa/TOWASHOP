using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOWALibrary.Models.Contact.Customers
{
    public class CustomerModel
    {
        #region Private Fields
        // Basic Info
        private string _CTID;
        private string _CID;
        private string firstName;
        private string lastName;
        // Delivery address
        private string contactPhone;
        private string address;
        private string city;
        private string country;
        // Meta info
        private string content;

       
      
        #endregion
        #region Property

        #region Display Attribute

        [DisplayName("#Customer ID")]
        public string CTID { get => _CTID; set => _CTID = value; }
       
        [DisplayName("Full Name")]
        public string FullName { get => string.Concat(FirstName, LastName); }
        
        [DisplayName("Phone")]
        [StringLength(20, ErrorMessage = "The maximum length of phone number is 20 characters!")]
        public string ContactPhone { get => contactPhone; set => contactPhone = value; }
        
        [DisplayName("Address")]
        public string FullAddress { get => String.Join(", ", Address, City, Country); }

        [DisplayName("Comment")]
        [StringLength(255, ErrorMessage = "The maximum length of the comment is 255 characters!")]
        public string Content { get => content; set => content = value; }

        #endregion

        #region Non-Display Attribute

        [Browsable(false)]
        [DisplayName("Citizen ID")]
        [StringLength(11, ErrorMessage = "The maximum length of the CID is 11 characters!")]
        public string CID { get => _CID; set => _CID = value; }

        [Browsable(false)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "First name is required")]
        [StringLength(15, ErrorMessage = "The maximum length of the first name is 15 characters!")]
        public string FirstName { get => firstName; set => firstName = value; }
       
        [Browsable(false)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last name is required")]
        [StringLength(15, ErrorMessage = "The maximum length of the last name is 15 characters!")]
        public string LastName { get => lastName; set => lastName = value; }

        [Browsable(false)]
        [StringLength(50, ErrorMessage = "The maximum length of the address is 50 characters!")]
        public string Address { get => address; set => address = value; }
        
        [Browsable(false)]
        [StringLength(20, ErrorMessage = "The maximum length of the city name is 20 characters!")]
        public string City { get => city; set => city = value; }
        
        [Browsable(false)]
        [StringLength(20, ErrorMessage = "The maximum length of the country name is 20 characters!")]
        public string Country { get => country; set => country = value; }

        #endregion

        #endregion


    }
}

//CREATE TABLE CUSTOMERS(
//	CUSTOMERID NVARCHAR(8), --CT1000 ~
//   CID NVARCHAR(11) NULL,
//	FIRST_NAME NVARCHAR(15) NOT NULL,
//	LAST_NAME NVARCHAR(15) NOT NULL,
//	CONTACT_PHONE VARCHAR(20) NOT NULL,
//	SL_ADDRESS NVARCHAR(50) NULL DEFAULT NULL,
//	CITY NVARCHAR(20) NULL DEFAULT NULL,
//	COUNTRY NVARCHAR(20) NULL DEFAULT NULL,
//	CONTENT NVARCHAR(MAX) NULL DEFAULT NULL,
//	CONSTRAINT PK_CUSTOMERS
//		PRIMARY KEY (CUSTOMERID),
//);
