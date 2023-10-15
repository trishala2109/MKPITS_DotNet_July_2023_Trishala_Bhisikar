using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_q11_quadratic_equation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            float result;

            Console.Write("Input the value of a : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the value of b : ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the value of c : ");
            c = Convert.ToInt32(Console.ReadLine());

            result = b * b - 4 * a * c;

            if(result!=0)
            {
                Console.WriteLine("Root are imaginary");
            }
            else
            {
                Console.WriteLine("Root are Real");
            }
            Console.ReadKey();
        }
    }
}
