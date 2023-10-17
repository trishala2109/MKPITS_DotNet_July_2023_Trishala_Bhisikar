using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_print_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, counter = 1, result = 0;
            Console.WriteLine("Enter the Number");
            number = Convert.ToInt32(Console.ReadLine());

            while(counter <= 10)
            {
                result = number * counter;
                Console.WriteLine("{0}*{1}={2}", number, counter, result);
                counter++;
            }
            Console.ReadKey();
        }
    }
}
