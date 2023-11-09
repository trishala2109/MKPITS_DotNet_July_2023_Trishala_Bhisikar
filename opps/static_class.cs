using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_class
{
    public static class Myclass
    {
        public static float PI = 3.14f;
        public static int Cube(int n)
        {
            return n*n*n;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("value of PI is " + Myclass.PI);
            Console.WriteLine("Cube of 5 is " + Myclass.Cube(5));

            Console.ReadKey();
        }
    }
}
