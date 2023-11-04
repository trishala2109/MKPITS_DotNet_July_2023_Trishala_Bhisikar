using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_prameterizes_constructor.cs
{
    internal class Program
    {
        class Book
        {
            int BookId;
            String Title;
            string Author;
            int Price;

            public Book() // without parameterized constructor
            {
                Console.WriteLine("\nBook Details without Parameters constructor\n");
                BookId = 123;
                Title = "John Wick";
                Author = "Tony Stark";
                Price = 1000;
            }

            // using Parameterized Conctructor

            public Book(int BookId, string Title, string Author, int price)
            {
                Console.WriteLine("\nBook Details using Parameterized constructor\n");
                this.BookId = BookId;
                this.Title = Title;
                this.Author = Author;
                this.Price = price;
            }
          
            public void display()
            {
                Console.WriteLine("Book ID: " +  BookId);
                Console.WriteLine("Book Title: " +  Title); 
                Console.WriteLine("Book Author: " +  Author);
                Console.WriteLine("Book Price: " +  Price);
            }

        }
        static void Main(string[] args)
        {
            Book b1 = new Book(); //  this will call constructor without parameters
            b1.display();

            Book b2 = new Book (123, "John Wick", "Tony Stark", 1200); //  this will call constructor with parameters
            b2.display();

            Console.ReadKey();
        }
    }
}
