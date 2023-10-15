using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_q14_triangle
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

            if(a == 60 || b == 60 || c == 60)
            {
                Console.WriteLine("The triangle is Equilateral");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("The triangle is Isosceles ");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene");
            }
            Console.ReadKey();
        }
    }
}
