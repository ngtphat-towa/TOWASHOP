using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOWALibrary.Repositories.DBConnector
{
    public class SqlDBConnector :IDBConnector
    {
        private string ConnectionString = DBManager.ConnectionString("SqlConnection");
        private DbConnection connection;
        public DbCommand CreateNewCommand( )
        {
            DbCommand dbCommand = new SqlCommand();
            dbCommand.Connection = connection;
            return dbCommand;
        }

        public DbConnection GetDbConnection()
        {
            connection = new SqlConnection(ConnectionString);
            return connection;
        }

        private static IDBConnector instance;
        public static IDBConnector GetInstance()
        {
            if( instance == null)
            {
                instance = new SqlDBConnector();
            }
            return instance;
        }

        public DbDataAdapter GetDbDataAdapter()
        {
            DbDataAdapter dbDataAdapter = new SqlDataAdapter();
            return dbDataAdapter;
        }
    }
}
