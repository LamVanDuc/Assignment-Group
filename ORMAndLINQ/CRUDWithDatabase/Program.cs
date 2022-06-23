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

                Menu();
                int c = int.Parse(Console.ReadLine());
                switch (c)

                {
                    case 1:
                        pro.ShowAll();
                        break;
                    case 2: pro.AddProduct();
                        break;
                    case 3: // delete product
                        break;
                    case 4:// view all product
                        break;
                    case 5: // Search by id
                        break;
                    case 6: pro.SearchProductByName();
                        break;
                    case 7://end
                        break;
                    default:
                        break;
                }
            }
            Console.ReadLine();

        }
        public static void Menu()
        {
            Console.WriteLine("========== Actions=========");
            Console.WriteLine("1. Show all");
            Console.WriteLine("2. Add Product");
            Console.WriteLine("3. Delete product");
            Console.WriteLine("4. View all product");
            Console.WriteLine("5. Search product by id");
            Console.WriteLine("6. Search product by name");
            Console.WriteLine("7. End");
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
        public void AddProduct()
        {
            AddProduct add = new AddProduct();
            Console.WriteLine("Enter product name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter product Description : ");
            string desc = Console.ReadLine();
            Console.WriteLine("Enter product Price :");
            double price = double.Parse(Console.ReadLine());
            Product product = new Product {ProductName = name , ProductDesc = desc , Price = price};
            add.getData(product);
        }

        public void SearchProductByName()
        {
            SearchProductByName search = new SearchProductByName();
            Console.WriteLine("Enter product name : ");
            string name = Console.ReadLine();
            search.GetData(name);
        }
    }
}