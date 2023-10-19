using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, fact = 1, counter;
            Console.WriteLine("Enter Number");
            number = Convert.ToInt32(Console.ReadLine());

            for(counter = number; counter > 0; counter--)
            {
                fact = fact * counter;
            }
            Console.WriteLine("Factorial = {0}", fact);
            Console.ReadKey();
        }
    }
}
