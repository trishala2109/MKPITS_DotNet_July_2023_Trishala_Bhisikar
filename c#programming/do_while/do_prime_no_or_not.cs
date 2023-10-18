using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_prime_no_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, counter = 2, flag = 0;
            Console.WriteLine("Enter Number");
            number = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (number % 2 == 0)
                {
                    flag = 1;
                    break;
                }
                counter++;
            } while (counter < number);
            if (flag == 0)
            {
                Console.WriteLine("No is prime");
            }
            else
            {
                Console.WriteLine("No is not prime");
            }
            Console.ReadKey();
        }
    }
}
