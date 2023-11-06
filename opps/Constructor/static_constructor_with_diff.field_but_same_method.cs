using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_constructor_with_diff.field_but_same_method
{
    internal class Program
    {
        class Book
        {
            static string Title;
            static string Author;

            static Book() // static class name are used in static constructor..........
            {
                Console.WriteLine("This is static constructor\n");
                Title = "Book of knowledge";
                Author = "Trishala Bhisikar";
            }

            public void display()
            {
                Console.WriteLine("Title: " + Title);
                Console.WriteLine("Author: " + Author);
            }
        }

        internal class program
        {

            static void Main(string[] args)
            {
                Book book1 = new Book();
                book1.display(); // this will call static constructor only...

                Book book2 = new Book();
                book2.display(); // this will not be call constructor...

                Console.ReadKey();
            }
        }
    }
}