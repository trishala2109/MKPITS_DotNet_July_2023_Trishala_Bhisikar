using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_indexOf_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 9, 3, 4 };
            int length = Array.IndexOf(array, 9);
            Console.WriteLine("the located of the number is = " + length);
            Console.ReadKey();
        }
    }
}
