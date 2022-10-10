using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOWALibrary.Models.Account.Roles
{
    public class RoleViewModel
    {
        #region Private Fields
        private int roleID;
        private string roleName;
        private string discription;

        #endregion

        #region Property
        [Display(Name = "RID")]
        [Required(ErrorMessage ="This account requires the user role!")]
        public int RoleID { get => roleID; set => roleID = value; }
        [Display(Name ="Role Name ")]
        [Required(ErrorMessage = "Role name is required to be defined")]
        public string RoleName { get => roleName; set => roleName = value; }
        [Display(Name = "Role Description ")]
        public string Discription { get => discription; set => discription = value; }
        #endregion
    }
}
