using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_Inheritance_Interface
{
    interface IDrawable
    {
        void Draw();
    }
    class Circle : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Drwa a circle");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle cir = new Circle();
            cir.Draw();
            Console.ReadKey();
        }
    }
}
