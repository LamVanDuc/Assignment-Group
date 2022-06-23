using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWithDatabase
{
    
    class ViewAllProduct
    {
        SqlConnection connection = new SqlServerConnection().getData();
        public List<Product> getData()
        {
            List<Product> products = new List<Product>();
            string query = "select * from Product";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) {
                int id = Convert.ToInt32(reader[0]);
                string name = Convert.ToString(reader[1]);
                string desc = Convert.ToString(reader[2]);
                double price = Convert.ToDouble(reader[3]);
                products.Add(new Product { Id = id , ProductName = name ,ProductDesc = desc , Price = price});
            }
            connection.Close();
            return products;
        }
        
    }
}
