using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_print_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, fact = 1;
            Console.WriteLine("Enter the Number");
            number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                fact = fact * number;
                number--;
            }
            Console.WriteLine("factorial = {0}", fact);
            Console.ReadKey();
        }
    }
}
