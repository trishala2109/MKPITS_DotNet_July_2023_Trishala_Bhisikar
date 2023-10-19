using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_print_1_to_10_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=1;
            for (number = 1; number <= 10; number++)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}
