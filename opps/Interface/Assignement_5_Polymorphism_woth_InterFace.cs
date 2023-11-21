using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_5_Polymorphism_woth_InterFace
{
    interface IAnimal
    {
        void MakeSound();
    }
    class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Bark Bark");
        }
    }

    class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow Meow");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal;

            animal = new Dog();
            animal.MakeSound();

            animal = new Cat();
            animal.MakeSound();

            Console.ReadKey();
        }
    }
}
