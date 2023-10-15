using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greater_no_check_3_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Enter Number 1");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 2");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 3");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
                Console.WriteLine("num 1 is greater");
            else if (num2 > num3)
                Console.WriteLine("num 2 is greater");
            else
                Console.WriteLine("num 3 is greater");

            Console.ReadKey();
        }
    }
}
