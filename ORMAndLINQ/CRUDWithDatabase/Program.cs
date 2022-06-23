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
                    case 3: pro.DeleteProduct();
                        break;
                    case 4:pro.EditProductByid();
                        break;
                    case 5: pro.SearchProductById();
                        break;
                    case 6: pro.SearchProductByName();
                        break;
                    case 7:Environment.Exit(0);
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
            Console.WriteLine("4. Edit product");
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
                Console.WriteLine(item.Id +"      "+ item.ProductName);
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
        public void SearchProductById()
        {
            SearchProductById searchid = new SearchProductById();
            Console.WriteLine("Enter Id : ");
            int id = int.Parse(Console.ReadLine());
            bool check = searchid.GetData(id);
            if (check == false)
            {
                Console.WriteLine("Not found !");
            }

        }
        public void DeleteProduct()
        {
            DeleteProduct delete = new DeleteProduct();
            Console.WriteLine("Enter product id :");
            int id = int.Parse(Console.ReadLine());
            delete.RemoveProduct(id);
        }
        public void EditProductByid()
        {
            List<Product> products = new ViewAllProduct().getData();

            Console.WriteLine("Enter product id to update : ");
            int id = int.Parse(Console.ReadLine());
            int i =0;
            foreach (Product item in products)
            {
                if (item.Id.Equals(id))
                {
                    Console.WriteLine("Enter new product Name :");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter new product Desc : ");
                    string desc = Console.ReadLine();
                    Console.WriteLine("Enter new price :");
                    double price = double.Parse(Console.ReadLine());
                    EditProduct edit = new EditProduct();
                    edit.EditProductById(new Product() { Id = id, ProductName = name, ProductDesc = desc, Price = price });
                    i = 0;
                    break;
                }
                else
                {

                    i = 1;
                }
            }
            if (i == 1)
            {
                Console.WriteLine("id {0} not found !" ,id);
            }
            
        }
    }
}
    

