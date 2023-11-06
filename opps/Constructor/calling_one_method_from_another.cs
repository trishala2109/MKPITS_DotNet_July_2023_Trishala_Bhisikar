using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calling_one_method_from_another
{
    internal class Program
    {
        class Book
        {
            public string Name;
            public int BookId;

            public void getdata(string Name)
            {
                Console.WriteLine("Method with One parameter");
                getdata(Name, 123); //  calling method with 2 parameters.....
            }

            public void getdata(string Name, int BookId)
            {
                Console.WriteLine("Method with two parameter");
                this.Name = Name;
                this.BookId = BookId;
            }

            public void display()
            {
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Book ID: " + BookId);
            }
        }
        static void Main(string[] args)
        {
            Book book = new Book();
            book.getdata("This is Book");
            book.display();

            Console.ReadKey();
        }
    }
}
