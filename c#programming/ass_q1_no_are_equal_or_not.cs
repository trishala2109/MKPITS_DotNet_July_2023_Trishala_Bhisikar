using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_q1_equal_or_not_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Enter number 1 :-");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number 2 :-");
            num2 = Convert.ToInt32(Console.ReadLine());

            if(num1==num2)
            {
                Console.WriteLine("The Number are Equal");
            }
            else
            {
                Console.WriteLine("The Number are not Equal");
            }
            Console.ReadKey();
        }
    }
}
