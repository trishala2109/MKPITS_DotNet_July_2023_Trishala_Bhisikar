using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macine_Test_2
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public virtual void MakingSound()
        {
            Console.WriteLine("Sounds of animals");
        }
    }
    class Mammal : Animal
    {
        public Mammal(string Name,int Age) : base(Name,Age)
        {

        }
        public override void MakingSound()
        {
            Console.WriteLine("Lion roars roars roars");
        }
    }
    class Raptile : Animal
    {
        public Raptile(string Name,int Age):base(Name,Age)
        {

        }
        public override void MakingSound()
        {
            Console.WriteLine("Snaks hiss hiss hiss");
        }
    }
    class Bird : Animal
    {
        public Bird(string Name,int Age):base (Name,Age)
        {

        }
        public override void MakingSound()
        {
            Console.WriteLine("Eagle buzzzzzz buzzzzzz");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mammal m = new Mammal("Lion",56);
            m.MakingSound();

            Raptile r = new Raptile("Snaks", 100);
            r.MakingSound();

            Bird b = new Bird("Sparrow", 12);
            b.MakingSound();

            Console.ReadKey();
        }
    }
}
