using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_q4_natural_no_average_calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=10, sum = 0, counter = 1, number;
            float average;
            Console.WriteLine("Input the 10 numbers ");
            

            while(counter <= num)
            {
                number = Convert.ToInt32(Console.ReadLine());
                sum += number;
                counter++;
            }
            average = sum / num;
            Console.WriteLine("The sum of number is : {0}",sum);
            Console.WriteLine("The Average is : {0}", average);

            Console.ReadKey();
        }
    }
}
