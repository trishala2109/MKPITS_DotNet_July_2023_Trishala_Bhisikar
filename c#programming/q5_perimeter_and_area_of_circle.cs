using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q5_perimeter_and_area_of_circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float radius;
            float peri;
            Console.WriteLine("Enter the Radius");
            radius = Convert.ToSingle(Console.ReadLine());
            peri = 2 * 3.14f * radius;
            Console.WriteLine("Area of Circle =" + peri);
            Console.ReadKey();


        }
    }
}
