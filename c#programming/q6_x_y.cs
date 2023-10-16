using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q6_x_y
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int y;
            Console.WriteLine("Enter the value of y :-");
            y = Convert.ToInt32(Console.ReadLine());

            uint x = (uint)(y * y + 2 * y + 1);
            Console.WriteLine("y \t|\t x");
            Console.WriteLine($"{y} \t|\t {x}");

            Console.ReadKey();
        }
    }
}
