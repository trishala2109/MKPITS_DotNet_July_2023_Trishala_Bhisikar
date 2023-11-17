using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overriding
{
    public class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Eating_______");
        }
    }
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eating Bread____________");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal d = new Dog();
            d.Eat();
            Console.ReadKey();
        }
    }
}
