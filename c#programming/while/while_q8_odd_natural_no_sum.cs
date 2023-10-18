using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_q8_odd_natural_no_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, counter = 1, sum = 0;

            Console.WriteLine("Input number of terms : ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("odd number are:");

            while(counter <= number)
            {
                Console.WriteLine("{0}", 2 * counter - 1);
                sum += 2 * counter - 1;
                counter++;
            }
            Console.WriteLine("The Sum of odd Number :- {0} ", sum);
            Console.ReadKey();
        }
    }
}
