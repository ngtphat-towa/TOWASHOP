using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Account.Users;

namespace TOWALibrary.Services.CommonServices
{
   public static class GlobalConfig
    {
        private static AccountModel _CurrentUser;

        public static AccountModel CurrentUser { get => _CurrentUser; set => _CurrentUser = value; }
    }
}
