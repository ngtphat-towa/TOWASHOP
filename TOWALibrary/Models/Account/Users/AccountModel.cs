using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Account.Roles;

namespace TOWALibrary.Models.Account.Users
{
    public class AccountModel
    {
        #region Private Feild
        private string _UID;
        private string username;
        private RoleViewModel role;
        private string _PasswordHash;
        private DateTime _RegisterAt;
        private DateTime _LastLogin;
        private string content;

        #endregion
        #region Property
        [DisplayName ("UID")]
        public string UID { get => _UID; set => _UID = value; }

        [DisplayName ("Username")]
        [Required (ErrorMessage ="The username is required")]
        [StringLength(25,MinimumLength = 4, ErrorMessage = "The username must be between 3 and 25 characters")]
        public string Username { get => username; set => username = value; }

        public int RoleID { get; set; }

        [Display (Name ="RoleName",ResourceType =typeof(RoleViewModel))]
        [Required(ErrorMessage = "The user role is required")]
        [StringLength(25, MinimumLength = 4, ErrorMessage = "The username must be between 3 and 25 characters")]
        public RoleViewModel Role { get => role; set => role = value; }

        [DisplayName("Password")]
        public string PasswordHash { get => _PasswordHash; set => _PasswordHash = value; }
        [DisplayName ("Register At")]
        public DateTime RegisterAt { get => _RegisterAt; set => _RegisterAt = value; }
        [DisplayName("Last login")]
        public DateTime LastLogin { get => _LastLogin; set => _LastLogin = value; }
        public string Content { get => content; set => content = value; }
        #endregion
    }
}
