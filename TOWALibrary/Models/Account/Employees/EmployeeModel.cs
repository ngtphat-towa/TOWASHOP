using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Account.Users;

namespace TOWALibrary.Models.Account.Employees
{
   public class EmployeeModel
    {
        #region Private Feilds
        private string _EID;
        // Personal Information
        private string _CID;
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private int sex;
        // Job title
        private string title;
        private DateTime hideDate;
        // Contact Information
        private string address;
        private string city;
        private string country;
        private string phoneNumber;
        // Meta
        private AccountModel _account;
        private DateTime _UpdateAt;
        private string content;
        private string _UID;
        #endregion

        #region Property

        #region Display Attribute
        [DisplayName("#ID")]
        public string EID { get => _EID; set => _EID = value; }

        [DisplayName("Account ID")]
        public string UID { get => _UID; set => _UID = value; }

        [DisplayName("Name")]
        public string FullName { get => String.Join(" ", FirstName, LastName); }

        [DisplayName("Sex")]
        public string SexString { get => (Sex == 0) ? "Male" : "Female"; }

        [DisplayName("Position")]
        [StringLength(25, ErrorMessage = "The maximum length of the title is 25 characters!")]
        public string Title { get => title; set => title = value; }

        [DisplayName("Hided Date")]
        public DateTime HideDate { get => hideDate; set => hideDate = value; }

        [DisplayName("Contact")]
        [StringLength(20, ErrorMessage = "The maximum length of phone number is 20 characters!")]
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        [DisplayName("Address")]
        public string FullAddress => String.Join(", ", Address, City, Country);

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
        [Required(AllowEmptyStrings =false,ErrorMessage = "First name is required")]
        [StringLength(15, ErrorMessage = "The maximum length of the first name is 15 characters!")]
        public string FirstName { get => firstName; set => firstName = value; }

        [Browsable(false)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last name is required")]
        [StringLength(15, ErrorMessage = "The maximum length of the last name is 15 characters!")]
        public string LastName { get => lastName; set => lastName = value; }

        [Browsable(false)]
        [DisplayName("Birthday")]
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }

        [Browsable(false)]
        [Range(0, 1, ErrorMessage = "The sex is about 0 to 1. ")]
        public int Sex { get => sex; set => sex = value; }

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
        public DateTime UpdateAt { get => _UpdateAt; set => _UpdateAt = value; }

        [Browsable(false)]
        [DisplayName("Username")]
        public AccountModel Account { get => _account; set => _account = value; }

        #endregion
        
        #endregion
    }
}
