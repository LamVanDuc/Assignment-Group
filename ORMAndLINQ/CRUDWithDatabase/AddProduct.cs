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
        public void getData(Product product)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Insert into product values (@proName,@proDesc,@price)", connection);
            command.Prepare();
            command.Parameters.AddWithValue("@proName", product.ProductName);
            command.Parameters.AddWithValue("@proDesc", product.ProductDesc);
            command.Parameters.AddWithValue("@price", product.Price);
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
