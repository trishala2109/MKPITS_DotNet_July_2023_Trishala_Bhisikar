using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_each_using_array_another_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 50 };
            int sum = 0;
            foreach( int i in array)
            {
                Console.WriteLine(i);
                sum = sum + i;
            }
            Console.WriteLine("sum of all elements is :- " + sum);
            Console.ReadKey();
        }
    }
}
