using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWithDatabase
{
    class EditProduct
    {
        public void EditProductById(Product product)
        {
            SqlConnection connection = new SqlServerConnection().getData();
            SqlCommand command = new SqlCommand("Update product set proName = @proName , proDesc = @proDesc , Price =@price where id = @id",connection);
            command.Parameters.AddWithValue("@id", product.Id);
            command.Parameters.AddWithValue("@proName", product.ProductName);
            command.Parameters.AddWithValue("@proDesc", product.ProductDesc);
            command.Parameters.AddWithValue("@price",product.Price);
            connection.Open();
            int check = command.ExecuteNonQuery();
            if (check >0)
            {
                Console.WriteLine("Update success !");
            }
            else
            {
                Console.WriteLine("Update false !");
            }
            connection.Close();
        }
    }
}
