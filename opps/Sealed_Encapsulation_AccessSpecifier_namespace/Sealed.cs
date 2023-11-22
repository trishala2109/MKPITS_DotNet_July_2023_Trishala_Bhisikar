using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed
{
    sealed class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating_____");
        }
    }
    class Dog : Animal  //'Dog' : cannot derive from sealed type 'Animal'
    {
        public void Bark()
        {
            Console.WriteLine("Barking_____");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.Bark();
            Console.ReadLine();
        }
    }
}
