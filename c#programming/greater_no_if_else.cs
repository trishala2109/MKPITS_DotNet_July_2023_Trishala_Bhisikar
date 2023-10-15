using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greater_no_if_else
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Enter the  Number 1");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the  Number 2");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine("num1 is greater");
            else
                Console.WriteLine("num2 is greater");

            Console.ReadKey();
        }
    }
}
