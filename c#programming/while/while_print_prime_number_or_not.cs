using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_prime_number_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, counter = 2, flag = 0;
            Console.WriteLine("Enter the Number");
            number = Convert.ToInt32(Console.ReadLine());

            while (counter < number)
            {
                if (number % 2 == 0)
                {
                    flag = 1;
                    break;
                }
                counter++;
            }
                if(flag == 0)
                {
                    Console.WriteLine("Number is prime");
                }
                else
                {
                    Console.WriteLine("Number is not prime");
                }
       
            Console.ReadKey();
        }
    }
}
