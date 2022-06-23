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
        List<Product> products = new ViewAllProduct().getData();
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
            
            var product = products.OrderBy(pro => pro.ProductName);
            foreach (var item in product)
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
            searchid.GetData(id);
            

        }
        public void DeleteProduct()
        {
            DeleteProduct delete = new DeleteProduct();
            Console.WriteLine("Enter product id :");
            int id = int.Parse(Console.ReadLine());
            if ((products.Select(p => p.Id)).Equals(id))
            {
                delete.RemoveProduct(id);
            }
            else {
                Console.WriteLine("ID {0} Not Found !" ,id);
            }
            
        }
        public void EditProductByid()
        {
            

            Console.WriteLine("Enter product id to update : ");
            int id = int.Parse(Console.ReadLine());

            if ((products.Select(p => p.Id)).Equals(id))
            {
                Console.WriteLine("Enter new product Name :");
                string name = Console.ReadLine();
                Console.WriteLine("Enter new product Desc : ");
                string desc = Console.ReadLine();
                Console.WriteLine("Enter new price :");
                double price = double.Parse(Console.ReadLine());
                EditProduct edit = new EditProduct();
                edit.EditProductById(new Product() { Id = id, ProductName = name, ProductDesc = desc, Price = price });
            }
            else
            {

                Console.WriteLine("id {0} not found !", id);
            }
            
        }
    }
}
    

