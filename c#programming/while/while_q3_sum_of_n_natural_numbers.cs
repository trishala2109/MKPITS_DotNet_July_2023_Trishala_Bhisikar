using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_sum_of_n_natural_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=10, sum=0;
            int counter = 1;
            Console.WriteLine("The first 7 natural number is :");
            while (counter <= 7)
            {
                Console.Write(+ counter +"");
                sum += counter;
                counter++;
            }
            Console.WriteLine("\nThe Sum of Natural Number upto 7 terms : " + sum);
            Console.ReadKey();
        }
    }
}
