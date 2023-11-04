using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copy_constructor
{
    internal class Program
    {
        class Book
        {
            int BookId;
            string Name;

            public Book()
            {
                BookId = 123;
                Name = "Game of Thrones";
            }
            public Book(Book book2)
            {
                BookId = book2.BookId;
                Name = book2.Name;
            }
           public void display()
            {
                Console.WriteLine("Book ID: " +  BookId);
                Console.WriteLine("Book Name: " +  Name);
            }

        }
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Console.WriteLine("\n--------- Book1 Details -----------\n");
            book1.display();
            
            Book book2 = new Book();
            Console.WriteLine("\n---------- Book2 Details -----------\n");
            book2.display();
        
            Console.ReadKey();
        }
    }
}
