using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_out_of_range_exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 11, 12, 13 };
            try
            {
                for (int i = 0; i <= 3; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            catch(IndexOutOfRangeException IE) //System.IndexOutOfRangeException: Index was outside the bounds of the array.
            {
                Console.WriteLine(IE.ToString());
            }
            Console.ReadLine();
        }
    }
}
