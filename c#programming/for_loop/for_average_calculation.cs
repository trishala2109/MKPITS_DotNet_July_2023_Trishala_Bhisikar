using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_average_calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter, sum=0, num;
            float average=0;
            

            for(counter = 1; counter <= 10; counter++)
            {
                Console.WriteLine("Input the 10 numbers ");
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
                average = sum / 10.0f;
            }
           
            Console.WriteLine("The sum of number is : {0}", sum);
            Console.WriteLine("The Average is : {0}", average);
            Console.ReadKey();
        }
    }
}
