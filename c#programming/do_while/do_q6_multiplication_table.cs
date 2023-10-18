using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_q6_multiplication_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, counter=1, result=0;
            Console.WriteLine("Input the number (Table to be calculated) : ");
            num = Convert.ToInt32(Console.ReadLine());

            do
            {
                result = num * counter;
                Console.WriteLine("{0}*{1}={2}",num,counter,result);
                counter++;
            } while (counter <= 10);
            
            Console.ReadKey();
        }
    }
}
