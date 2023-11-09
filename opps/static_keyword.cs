using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Statickey
    {
        public static int BookID;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Statickey.BookID = 123;
            Console.WriteLine("Book ID: " + Statickey.BookID);

            Console.ReadKey();
        }
    }
}
