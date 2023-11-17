using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_Polymorphisum_with_Data_Member
{
    public class Animal
    {
        public string color = "White";
    }
    public class Dog:Animal
    {
        public string color = "Black";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal d = new Dog();
            Console.WriteLine(d.color);
            Console.ReadKey();
        }
    }
}
