using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWithDatabase
{
    class SearchProductById
    {
        public void GetData(int id)
        {
            List<Product> products = new ViewAllProduct().getData();
            var findid = products.Where(pro => pro.Id.Equals(id));

            foreach (var product in findid)
            {
                Console.WriteLine(product.Id+"name :"+ product.ProductName +"  desc : "+product.ProductDesc);
            }
        }
    }
}
