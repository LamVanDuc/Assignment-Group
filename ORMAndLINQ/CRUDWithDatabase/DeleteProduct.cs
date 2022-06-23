using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWithDatabase
{
    class DeleteProduct
    {
        public void RemoveProduct(int id)
        {
            SqlConnection connection = new SqlServerConnection().getData();
            ViewAllProduct viewall = new ViewAllProduct();
            List<Product> products = viewall.getData();
            var check = products.Where(pro=> pro.Id == id);

            if (check != null)
            {
                connection.Open();

                SqlCommand command = new SqlCommand("Delete from product where id = @id ",connection);
                command.Parameters.AddWithValue("@id", id);
                int i = command.ExecuteNonQuery();
                if (i >0)
                {
                    Console.WriteLine("Delete success !");
                }
                else
                {
                    Console.WriteLine("Delete false !");
                }

            }
            else
            {
                Console.WriteLine("ID {0} not found !",id);
            }
        }
    }
}
