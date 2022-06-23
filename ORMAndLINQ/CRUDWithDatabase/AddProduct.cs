using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace CRUDWithDatabase
{
    class AddProduct
    {
        SqlConnection connection = new SqlServerConnection().getData("Dbtest");
        public void getData()
        {
            List<Product> products = new List<Product>();
            string query = "insert into product values(@value1 , @value2 , @value3)";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            int check = command.ExecuteNonQuery();
            if (check>=1)
            {
                Console.WriteLine("Add success !");
            }
            else
            {
                Console.WriteLine("Add false !");
            }
            connection.Close();
        }

    }
}
