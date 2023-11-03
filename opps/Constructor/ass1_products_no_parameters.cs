using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_with_no_parameters_a1
{
    internal class Program
    {
        class Product
        {
            int ProductId;
            string ProductName;
            int price;
            int Quantity;

            public Product()
            { 
                ProductId = 123;
                ProductName = "Chips";
                price = 10;
                Quantity = 20;
            }

            public void display()
            {
                Console.WriteLine("\n-------- Product Details ----------\n");
                Console.WriteLine("Product ID: " +  ProductId);
                Console.WriteLine("Product Name: " + ProductName);
                Console.WriteLine("Price: " +  price);
                Console.WriteLine("Quantity: " +  Quantity);
            }
        }
        static void Main(string[] args)
        {
            Product product = new Product();
            product.display();
            Console.ReadKey();
        }
    }
}
