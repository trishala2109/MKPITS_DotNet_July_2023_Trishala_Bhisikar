using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructor
{
    class Book
    {
        static string title;

        static Book()
        {
            Console.WriteLine("It is a Static Method");
            title = "Csharp";
        }

        public static void display()
        {
            Console.WriteLine("Title :- " + title);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book.display();
            Console.ReadKey();
        }
    }
}
