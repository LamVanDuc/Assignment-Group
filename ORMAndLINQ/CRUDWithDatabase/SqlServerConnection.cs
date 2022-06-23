using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CRUDWithDatabase
{
    class SqlServerConnection
    {
        public  SqlConnection getData(string databaseName)
        {
            string connectionString = "Data source = localhost ; Initial Catalog = Dbtest ; User = lamduc ; Password = 123456";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
