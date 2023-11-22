using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected_Internal_access_Specifier
{
    class Employee
    {
        protected internal int ID;
        protected internal string Name;
        protected  internal void Display()
        {
            Console.WriteLine("ID : " + ID);
            Console.WriteLine("Name : " + Name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Name = "John";
            emp.ID = 56321;
            emp.Display();
            Console.ReadLine();
        }
    }
}
