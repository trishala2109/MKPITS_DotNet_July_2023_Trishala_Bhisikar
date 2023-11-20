using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstration_Shape_Class
{
    abstract class Shape
    {
        public abstract void Draw();
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw Rectangle________________");
        }
    }
    class Circle:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw Circle________________");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Rectangle();
            s.Draw();

            s = new Circle();
            s.Draw();

            Console.ReadLine();
        }
    }
}
