using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_q8_largest_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Enter the number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number 3");
            num3 = Convert.ToInt32(Console.ReadLine());

            if(num1>num2&&num1>num3)
            {
                Console.WriteLine("The number 1 is greater");
            }
            else if(num2>num3)
            {
                Console.WriteLine("The number 2 is greater");
            }
            else
            {
                Console.WriteLine("The number 3 is greater");
            }
            Console.ReadKey();
        }
    }
}
