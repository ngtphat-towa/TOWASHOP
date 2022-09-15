using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Account.Roles;

namespace TOWALibrary.Repositories.Accounts.Roles
{
    public interface IRoleRepository
    {
        IEnumerable<RoleModel> GetRole_All();
    }
}
