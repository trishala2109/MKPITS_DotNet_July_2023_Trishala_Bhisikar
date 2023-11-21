using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Keyword
{
    class Animal
    {
        public string color = " White";
    }
    class Dog : Animal
    {
        public string color = "Red";
        public void DisplayColor()
        {
            Console.WriteLine("Dog Color is : " + color);
            Console.WriteLine("Animal Color is : " + base.color);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.DisplayColor();
            Console.ReadLine();
        }
    }
}
