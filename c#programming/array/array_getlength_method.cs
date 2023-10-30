using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_getlength_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 8, 6 };
            int length = array.GetLength(0);
            Console.WriteLine("array length is = "+ length);
            Console.ReadKey();
        }
    }
}
