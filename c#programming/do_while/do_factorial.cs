using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, fact = 1;
            Console.WriteLine("Enter Number");
            number = Convert.ToInt32(Console.ReadLine());
            do
            {
                fact = fact * number;
                number--;
            } while (number > 0);
            Console.WriteLine("factorial = {0}", fact);
            Console.ReadKey();
        }
    }
}
