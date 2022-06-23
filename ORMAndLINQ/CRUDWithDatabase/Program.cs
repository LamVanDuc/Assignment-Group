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
            Program pro = new Program();
            while (true)
            {
                Console.WriteLine("1. Show all");
                Console.WriteLine("2. Add Product");
                int c = int.Parse(Console.ReadLine());
                switch (c)

                {
                    case 1:
                        pro.ShowAll();
                        break;
                    default:
                        break;
                }
            }
            Console.ReadLine();

        }
        public void ShowAll()
        {
            ViewAllProduct viewall = new ViewAllProduct();
            List<Product> products = viewall.getData();
            foreach (var item in products)
            {
                Console.WriteLine(item.Id + item.ProductName);
            }
        }
    }
}