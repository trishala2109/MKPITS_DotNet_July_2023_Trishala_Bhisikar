using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace return_value_factorial
{
    internal class Program
    {
        static int calculate(int num)
        {
            int fact = 1;
            while(num > 0)
            {
                fact = fact * num;
                num--;
            }
            return fact;
        }
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter number");
            number = Convert.ToInt32(Console.ReadLine());

            int result = calculate(number);
            Console.WriteLine("Factorial = " + result);
            Console.ReadKey();
        }
    }
}
