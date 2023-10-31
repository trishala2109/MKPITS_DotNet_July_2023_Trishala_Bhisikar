using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_rectangle
{
    class Reactangel
    {
        int width;
        int height;

        public void getData(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public void Calculate()
        {
            int area;
            area = width * height;
            Console.WriteLine("Area of Rectangle : - " + area);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Reactangel area = new Reactangel();
            area.getData(5, 10);
            area.Calculate();
            Console.ReadKey();
        }
    }
}
