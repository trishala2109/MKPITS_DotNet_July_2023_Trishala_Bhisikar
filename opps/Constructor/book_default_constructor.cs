using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_class_of_default_constructor
{
    internal class Program
    {
        class Book
        {
            int BookId;
            string Title;
            string Author;
            int Price;

            public Book()
            {
                BookId = 123;
                Title = "Stranger Things";
                Author = "John wick";
                Price = 1200;
            }

            public void display()
            {
                Console.WriteLine("Book ID: " +  BookId);
                Console.WriteLine("Book Name: " + Title);
                Console.WriteLine("Book Author: " +  Author);
                Console.WriteLine("Book Price: " +  Price);
            }
        }
        static void Main(string[] args)
        {
            Book book = new Book();
            book.display();
            Console.ReadKey();
        }
    }
}