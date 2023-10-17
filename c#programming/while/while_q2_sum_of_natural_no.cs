using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_q2_sum_of_natural_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=10,sum=0,counter=1;
            Console.WriteLine("The Sum of first 10 Natural Number is");
            

            while (counter <= 10)
            {
                Console.Write(counter);
                sum += counter;
                counter++;
            }
            Console.WriteLine("\nThe Sum is : " + sum);
            Console.ReadKey();
        }
    }
}
