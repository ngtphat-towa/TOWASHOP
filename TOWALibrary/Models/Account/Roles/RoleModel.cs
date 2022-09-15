using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOWALibrary.Models.Account.Roles
{
    public class RoleModel
    {
        #region Private Fields
        private int roleID;
        private string roleName;
        private string discription;
        
        #endregion

        #region Property
        public int RoleID { get => roleID; set => roleID = value; }
        public string RoleName { get => roleName; set => roleName = value; }
        public string Discription { get => discription; set => discription = value; }
        #endregion
    }
}
