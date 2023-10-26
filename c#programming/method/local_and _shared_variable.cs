using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace local_and_shared_variable
{
    internal class Program
    {
        static int num = 20;
        
        static void display()
        {
            int num = 10;
            Console.WriteLine("num inside method " + num);
        }
        static void Main(string[] args)
        {
            display();
            Console.WriteLine("shared number " + num);
            Console.ReadKey();
        }
    }
}
