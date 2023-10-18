using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_sum_of_n_natural_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10, sum = 0;
            int counter = 1;
            Console.WriteLine("The first 7 natural number is :");

            do
            {
                Console.Write(+counter + "");
                sum += counter;
                counter++;
            } while (counter <= 7) ;

            Console.WriteLine("\nThe Sum of Natural Number upto 7 terms : " + sum);
            Console.ReadKey();
        }
    }
}

