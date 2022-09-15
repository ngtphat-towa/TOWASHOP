using System;
using System.Collections.Generic;
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
        private RoleModel role;
        private string _PasswordHash;
        private DateTime _RegisterAt;
        private DateTime _LastLogin;

        #endregion
        #region Property
        public string UID { get => _UID; set => _UID = value; }
        public string Username { get => username; set => username = value; }
        public int RoleID { get; set; }
        public RoleModel Role { get => role; set => role = value; }
        public string PasswordHash { get => _PasswordHash; set => _PasswordHash = value; }
        public DateTime RegisterAt { get => _RegisterAt; set => _RegisterAt = value; }
        public DateTime LastLogin { get => _LastLogin; set => _LastLogin = value; }
        #endregion
    }
}
