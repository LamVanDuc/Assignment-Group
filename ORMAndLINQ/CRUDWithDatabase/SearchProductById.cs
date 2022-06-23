using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWithDatabase
{
    class SearchProductById
    {
        public bool GetData(int id)
        {
            bool check = false;
            List<Product> products = new ViewAllProduct().getData();
            var findid = products.Where(pro => pro.Id.Equals(id));
            if (findid != null)
            {
                check = true;
                foreach (var product in findid)
                {
                    Console.WriteLine(product.Id + "name :" + product.ProductName + "  desc : " + product.ProductDesc);
                }
            }
            else
            {
                Console.WriteLine("Id {0} not found !",id);
                check = false;
            }
            return check;
        }
    }
}
