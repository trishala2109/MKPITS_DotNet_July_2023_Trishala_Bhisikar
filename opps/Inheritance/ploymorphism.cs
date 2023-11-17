using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class BaseClass
    {
        public virtual void Show()
        {
            Console.WriteLine("Hello from base class show method");
        }
    }
    class ChildeClass : BaseClass
    {
        public override void Show()
        {
            Console.WriteLine("Hello from child class show method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass b = new ChildeClass();
            b.Show();
            Console.ReadKey();
        }
    }
}
