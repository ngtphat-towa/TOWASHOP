using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOWALibrary.Repositories
{
   public interface IDBConnector
    {
        DbConnection GetDbConnection();
        DbCommand CreateNewCommand( );
    }
}
