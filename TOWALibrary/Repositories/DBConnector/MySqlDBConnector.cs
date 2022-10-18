using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace TOWALibrary.Repositories.DBConnector
{
   public class MySqlDBConnector: IDBConnector
    {
        public MySqlDBConnector()
        {
            ConnectionString = DBManager.ConnectionString("SqlConnection");
            connection = new MySqlConnection(ConnectionString);
        }
        private readonly string ConnectionString;
        private DbConnection connection;
        public DbCommand CreateNewCommand()
        {
            DbCommand dbCommand = new MySqlCommand();
            dbCommand.Connection = connection;
            return dbCommand;
        }

        public DbConnection GetDbConnection()
        {
            connection = new MySqlConnection(ConnectionString);
            return connection;
        }

        private static IDBConnector instance;
        public static IDBConnector GetInstance()
        {
            if (instance == null)
            {
                instance = new SqlDBConnector();
            }
            return instance;
        }

        public DbDataAdapter GetDbDataAdapter()
        {
            DbDataAdapter dbDataAdapter = new MySqlDataAdapter();
            return dbDataAdapter;
        }
    }
}
