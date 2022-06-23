using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWithDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServerConnection sql = new SqlServerConnection();
            SqlConnection conn =  sql.getData("Dbtest");
            if (conn != null)
            {
                Console.WriteLine("ket noi thanh cong");
            }
            Console.ReadLine();
        }
    }
}
