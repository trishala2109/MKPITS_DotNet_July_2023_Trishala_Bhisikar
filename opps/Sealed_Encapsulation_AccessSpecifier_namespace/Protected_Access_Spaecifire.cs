using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected_Access_Spaecifire
{
    class Person
    {
        protected string Name = "Shikha";
        protected void Display()
        {
            Console.WriteLine("Name :- " + Name);
        }
    }
     class Program:Person
     {
        static void Main(string[] args)
        {
            Program emp = new Program();
            Console.WriteLine("Hello  " + emp.Name);
            emp.Display();
            Console.ReadLine();
        }
    }
}
