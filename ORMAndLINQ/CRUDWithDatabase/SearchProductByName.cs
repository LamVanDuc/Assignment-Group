using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace CRUDWithDatabase
{
    class SearchProductByName
    {
        public void GetData(string name)
        {
            List<Product> products = new ViewAllProduct().getData();
            var find = products.Where(pro => pro.ProductName.Contains(name));

            foreach (var product in find)
            {
                Console.WriteLine(product.Id+"name :"+ product.ProductName +"  desc : "+product.ProductDesc);
            }
                
        }
         
    }
}
