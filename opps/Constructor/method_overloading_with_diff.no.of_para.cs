using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading_with_diff.no.of_para
{
    internal class Program
    {
        class Book
        {
            public int BookId;
            public string Title;
            public string Author;
            public int Price;
            public void getdata(int BookId)
            {
                this.BookId = BookId;
            }

            public void getdata(int BookId, string Title)
            {
                this.BookId = BookId;
                this.Title = Title;
            }

            public void getdata(int BookId, string Title, string Author)
            {
                this.BookId = BookId;
                this.Title = Title;
                this.Author = Author;
            }

            public void getdata(int BookId, string Title, string Author, int Price)
            {
                this.BookId = BookId;
                this.Title = Title;
                this.Author = Author;
                this.Price = Price;
            }
            public void display()
            {
                Console.WriteLine("Book ID: " + BookId);
                Console.WriteLine("Title: " + Title);
                Console.WriteLine("Author: " + Author);
                Console.WriteLine("Price: " + Price);
            }
        }
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Console.WriteLine("\n-------- Book 1 ----------\n");
            book1.getdata(123);
            book1.display();

            Book book2 = new Book();
            Console.WriteLine("\n-------- Book 2 ----------\n");
            book2.getdata(123, "This is Book");
            book2.display();

            Book book3 = new Book();
            Console.WriteLine("\n-------- Book 3 ----------\n");
            book3.getdata(123, "This is Book", "tony stark");
            book3.display();

            Book book4 = new Book();
            Console.WriteLine("\n-------- Book 4 ----------\n");
            book4.getdata(123, "This is Book", "tony stark", 1200);
            book4.display();

            Console.ReadKey();
        }
    }
}
