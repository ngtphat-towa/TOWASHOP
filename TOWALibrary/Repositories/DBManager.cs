using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Repositories.DBConnector;

namespace TOWALibrary.Repositories
{

    public enum DataProvider
    {
        SQLServer,
        MySQL
    }
   public static class DBManager
    {
        public static string ConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        public static IDBConnector Connection { get; private set; }

        public static void InitializeConnections(DataProvider db)
        {
            switch (db)
            {
                case DataProvider.SQLServer:
                    Connection = SqlDBConnector.GetInstance() ;

                   
                    break;
                case DataProvider.MySQL:
                    break;
            }
        }
       
        

    }
}