using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace class_booklibrary
{
    class BookLibrary
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }

        public void getData(string Title, string Author, bool IsAvailable)
        {
            this.Title = Title;
            this.Author = Author;
            this.IsAvailable = IsAvailable;
        }
        public void LibraryBook()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Book Title :- " + Title);
            Console.WriteLine("Book Author Name :- " + Author);
            Console.WriteLine("Book isAvailabe :- " + IsAvailable);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BookLibrary[] book = new BookLibrary[3];
            book[0] = new BookLibrary();
            book[1] = new BookLibrary();
            book[2] = new BookLibrary();

            string title=null;
            string author=null;
            

            Console.WriteLine("---------------Enter Books Details----------------");
            for(int i = 0; i < 3; i++)
            {
                Console.Write("Enter Book Title :- ");
                title = Console.ReadLine();

                Console.Write("Enter Book Author :- ");
                title = Console.ReadLine();

                bool isAvailable = true;
                Console.WriteLine("-------------------------------------------------");
                book[i].getData(title, author, isAvailable);
            }

            Console.WriteLine("---------------Displaying Books----------------");
            foreach (var books in book)
            {
                books.LibraryBook(); 
            }

            Console.ReadKey();
        }
    }
}
