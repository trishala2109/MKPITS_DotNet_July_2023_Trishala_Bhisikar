using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace output_parameter
{
    internal class Program
    {
        static void calculate(int radius,out float area,out float circum)
        {
            area = 3.14f * radius * radius;
            circum = 2 * 3.14f * radius;
        }
        static void Main(string[] args)
        {
            int radius = 5;
            float area, circum;
   
            calculate(radius, out area, out circum);

            Console.WriteLine("Area of Circle =" + area);
            Console.WriteLine("Circumfrance of Circle = " + circum);

            Console.ReadKey();
        }
    }
}
