using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_clear_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 52, 63, 85 };
            Array.Clear(array, 0, array.Length);

            for( int i = 0; i <array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
