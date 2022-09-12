using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Model.Account.Users;

namespace TOWALibrary.Model.Account.Employees
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

        #endregion

        #region Property
        public string EID { get => _EID; set => _EID = value; }
        public string CID { get => _CID; set => _CID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public int Sex { get => sex; set => sex = value; }
        public string Title { get => title; set => title = value; }
        public DateTime HideDate { get => hideDate; set => hideDate = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public DateTime UpdateAt { get => _UpdateAt; set => _UpdateAt = value; }
        public string Content { get => content; set => content = value; }
        public AccountModel Account { get => _account; set => _account = value; }
        #endregion
    }
}
