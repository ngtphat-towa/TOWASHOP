using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOWALibrary.Repositories.Helpers
{
   public static class DBHelper
    {
        public static DbParameter CreateDbParameter(this DbCommand command, 
            string parameterName, DbType dbType, object value, 
            ParameterDirection direction=ParameterDirection.Input,  string sourceColumn = null, int size=0)
        {
            DbParameter p = command.CreateParameter();
            p.ParameterName = parameterName;
            p.Direction = direction;
            p.Value = value;
            p.DbType = dbType;
            p.Size = size;
            p.SourceColumn = sourceColumn;
            command.Parameters.Add(p);
            return p;
        }
    }
}

