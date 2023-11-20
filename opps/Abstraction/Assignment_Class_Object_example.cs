using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Class_Object_example
{
    class MyClass
    {
        public string Name;
        public string Address;
        public void getData(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }
        public void displayData()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("NAME :- " + Name);
            Console.WriteLine("ADDRESS :- " + Address);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass c = new MyClass();

            Console.Write("Enter Name :- ");
            string name = Console.ReadLine();
            Console.Write("Enter Address :- ");
            string address = Console.ReadLine();

            c.getData(name, address);
            c.displayData();
            Console.ReadLine();
        }
    }
}
