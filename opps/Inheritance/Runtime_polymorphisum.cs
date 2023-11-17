using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_polymorphisum
{
    public class Shape
    {
        public virtual void draw()
        {
            Console.WriteLine("Drawing___________");
        }
    }
    public class Rectangle:Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Rectangle__________");
        }
    }
    public class Circle: Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Circle_____________");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Shape();
            s.draw();
            s = new Rectangle();
            s.draw();
            s = new Circle();
            s.draw();
            Console.ReadKey();
        }
    }
}
