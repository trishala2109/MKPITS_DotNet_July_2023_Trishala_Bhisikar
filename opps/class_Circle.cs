using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_Circle
{
    class Circle
    {
        public int Radius { get; set; }

        public void getData(int Radius)
        {
            this.Radius = Radius;
        }

        public void Calculate()
        {
            float area, circum;
            area = 3.14f * Radius * Radius;
            Console.WriteLine("Area of Circle = " + area);

            circum = 2 * 3.14f * Radius;
            Console.WriteLine("Circumfrance of Circle = " + circum);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circ = new Circle();

            circ.getData(7);
            circ.Calculate();
            Console.ReadKey();
        }
    }
}
