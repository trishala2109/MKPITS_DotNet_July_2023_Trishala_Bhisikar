using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_sum_of_5_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, sum = 0;
            int counter;
            
            for(counter = 1; counter <= 5; counter++)
            {
                Console.WriteLine("Enter Number");
                number = Convert.ToInt32(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine("Sum of 5 numbers is : {0}", sum);
            Console.ReadKey();

        }
    }
}
