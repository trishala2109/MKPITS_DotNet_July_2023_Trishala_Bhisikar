using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_q2_prime_no_method
{
    internal class Program
    {
        static void calculate(int num)
        {
            int counter=2, flag=0;
            while (num > counter)
            {
                if(counter % 2 == 0)
                {
                    flag = 1;
                    break;
                }
                counter++;
            }
            if (flag == 0)
            {
                Console.WriteLine("This is prime Number");
            }
            else
            {
                Console.WriteLine("This is not prime Number");
            }
        }
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter Number :-");
            number = Convert.ToInt32(Console.ReadLine());

            calculate(number);
            Console.ReadKey();
        }
    }
}
