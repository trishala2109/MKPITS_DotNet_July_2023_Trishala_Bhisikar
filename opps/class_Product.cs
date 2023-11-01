using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_Product
{
    class Product
    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int ProductItem { get; set; }

        public void getData(string ProductName, int ProductPrice,int ProductItem)
        {
            this.ProductName = ProductName;
            this.ProductPrice = ProductPrice;
            this.ProductItem = ProductItem;
        }

        public void display()
        {
            Console.WriteLine("Product :- " + ProductName);
            Console.WriteLine("Quantity :-" + ProductItem);
            Console.WriteLine("Price :- " + ProductPrice);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product pr = new Product();
            string name;
            int itme, price;
            int total;
            int stock = 20;

            Console.Write("Enter Product Name :- ");
            name = Console.ReadLine();
            Console.Write("How much you buy :- ");
            itme = Convert.ToInt32(Console.ReadLine());
            Console.Write("Amount : ");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------");

            if(itme > 0 && itme < stock)
            {
                int remaingstock = stock - itme;
                total = price * itme;

                pr.getData(name, price, itme);

                pr.display();
                Console.WriteLine("Total Price You Purches : " + total);
                Console.WriteLine("Remaining stocks are : {0}", remaingstock);
            }
            else
            {
                Console.WriteLine("Insufficiant in stock");
            }
            Console.ReadKey();
        }
    }
}
