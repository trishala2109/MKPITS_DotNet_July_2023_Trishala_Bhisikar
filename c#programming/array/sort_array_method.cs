using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_array_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 21, 5, 85 };
            Array.Sort(array);
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
