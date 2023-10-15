using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_q15_check_triamgle_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, total;
            Console.Write("Enter angle a :");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter angle b :");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter angle c :");
            c = Convert.ToInt32(Console.ReadLine());

            total = a + b + c;

            if (a == 60 || b == 60 || c == 60)
            {
                Console.WriteLine("The triangle is valid");
            }
            else
            {
                Console.WriteLine("The triangle is not valid");
            }
            Console.ReadKey();
        }
    }
}
