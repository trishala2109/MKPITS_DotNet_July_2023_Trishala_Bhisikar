using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_sum_of_odd_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, counter = 1, sum = 0;

            Console.WriteLine("Input number of terms : ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("odd number are:");

            for ( counter = 1; counter <= number; counter ++)
            {
                Console.WriteLine("{0}", 2 * counter - 1);
                sum += 2 * counter - 1;
            }
            Console.WriteLine("The Sum of odd Number :- {0} ", sum);
            Console.ReadKey();
        }
    }
}
