using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_and_non_static
{
    class Book
    {
        public static int ID;
        public static string Name;

        public void display(int ID, string Name)
        {
            Console.WriteLine("\nthis is Non static method");
            Console.WriteLine("Book ID2: " + ID);
            Console.WriteLine("Book Name2: " + Name);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // calling from class
            Book.ID = 12; // no instance needed for for non static
            Book.Name = "Static";

            Console.WriteLine("\nthis is static method");
            Console.WriteLine("Book ID1: " + Book.ID);
            Console.WriteLine("Book Name1: " + Book.Name);

            Book b = new Book(); //instance for non static
            b.display(123, "Non static");


            Program p = new Program();
            p.Main();

            Console.ReadKey();
        }
        void Main()
        {
            Console.WriteLine("\nCalling Form Another Main Method"); // calling Main
        }
    }
}
