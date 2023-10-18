using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_q4_average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num, sum=1, counter = 1, number=0;
            float average;
            Console.WriteLine("Input the 10 numbers ");
            num = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Number");
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                sum += number;
                average = sum / num;
                counter++;
            } while (counter <= num) ;
            
            Console.WriteLine("The sum of number is : {0}", sum);
           Console.WriteLine("The Average is : {0}", average);

            Console.ReadKey();
        }
    }
}
