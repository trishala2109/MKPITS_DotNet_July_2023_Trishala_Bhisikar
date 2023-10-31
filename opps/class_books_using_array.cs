using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace class_books_using_array
{
    class Books
    {
         string title;
         string author;
         int yera;
         
        public void getData(string title, string author, int yera)
        {
            this.title = title;
            this.author = author;
            this.yera = yera;
        }
        public void library()
        {
            Console.WriteLine("titla of book : -" + title);
            Console.WriteLine("Author of book :-" + author);
            Console.WriteLine("publcation of year :-" + yera);
            Console.WriteLine("----------------------------------");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Books[] bookied = new Books[3];
            bookied[0] = new Books();
            bookied[1] = new Books();
            bookied[2] = new Books();

            string auth=null;
            string nam = null;
            int yr = 0;

            Console.WriteLine("Enter Book Details");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter Title:-");
                auth = Convert.ToString(Console.ReadLine());

                Console.Write("Enter Author Name :- ");
                nam = Convert.ToString(Console.ReadLine());

                Console.Write("Enter Publication Year :- ");
                yr = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                bookied[i].getData(auth, nam, yr);
                
            }
            
            for (int i = 0; i < 3; i++)
            {
                bookied[i].library();
            }
            
            Console.ReadKey();
        }
    }
}
