using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace q8_volume_of_sphere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double sphere;
            double area;
            Console.WriteLine("Enter the Radius");
            radius = Convert.ToDouble(Console.ReadLine());
            area = 4 * 3.14 * radius * radius;
            sphere = 4/3*3.14*radius*radius*radius ;
            Console.WriteLine("Area of surface =" + area);
            Console.WriteLine("Volume of Sphere =" + sphere);
            Console.ReadKey();


        }
    }
}
