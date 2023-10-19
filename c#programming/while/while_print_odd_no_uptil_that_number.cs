using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_print_odd_no_uptil_that_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 1;
            int counter = 1;
            Console.WriteLine("Enter Number");
            number = Convert.ToInt32(Console.ReadLine());

            while(true)
            {
                if(sum <= number)
                {
                   if (counter % 2 != 0)
                    {
                        Console.WriteLine("Odd Number {0}", counter);
                        sum = sum + 1;
                    }
                }
                else
                {
                    break;
                }
                counter++;
            }
            Console.ReadKey();
        }
    }
}
