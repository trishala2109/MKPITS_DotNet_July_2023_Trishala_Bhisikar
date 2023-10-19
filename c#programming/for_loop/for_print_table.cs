using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_print_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, result = 0, counter;
            Console.WriteLine("Enter Number");
            number = Convert.ToInt32(Console.ReadLine());

            for (counter = 1; counter <= 10; counter++)
            {
                result = number * counter;
                Console.WriteLine("{0}*{1}={2}", number, counter, result);
            }
            
            Console.ReadKey();
        }
    }
}
