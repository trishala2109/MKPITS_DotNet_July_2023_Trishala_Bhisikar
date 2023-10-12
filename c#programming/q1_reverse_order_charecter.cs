using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_order_charecter
{
    internal class Program
    {
        public static void Main()
        {
            char b, a, t;
            Console.WriteLine("Enter b ");
            b = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter a");
            a = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter t ");
            t = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Reverse order :-" + t + " " + a + " " + b );

            Console.ReadKey();
        }
    }
}
