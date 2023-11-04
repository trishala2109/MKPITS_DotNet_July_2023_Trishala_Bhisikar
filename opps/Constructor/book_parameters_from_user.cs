using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameters_from_user
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
                Title = "Agent Jack";
                Author = "Robin Hood";
                Price = 1400;
            }

            public Book(int bookId, string title, string author, int price)
            {
                BookId = bookId;
                Title = title;
                Author = author;
                Price = price;
            }

            public void display()
            {
                Console.WriteLine("Book ID: " +  BookId);
                Console.WriteLine("Book Title: " +  Title);
                Console.WriteLine("Book Author: " +  Author);
                Console.WriteLine("BooK Price: " +  Price);
            }
        }
        static void Main(string[] args)
        {
            Book book = new Book();
            book.display();

            Console.WriteLine("\n----------- Enter Book Details -------------\n");

            Console.WriteLine("Enter book id: ");
            int ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter book title: ");
            string tit = Console.ReadLine();

            Console.WriteLine("Enter book author: ");
            string auth = Console.ReadLine();

            Console.WriteLine("Enter book price: ");
            int pr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n-------------------------------\n");

            Book book1 = new Book(ID, tit, auth, pr);
            book1.display();

            Console.ReadKey();
            
        }
    }
}
