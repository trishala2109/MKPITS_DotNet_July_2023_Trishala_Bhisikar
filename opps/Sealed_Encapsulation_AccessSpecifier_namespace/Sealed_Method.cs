using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Method
{
    class Person
    {
        public virtual void Display()
        {
            Console.WriteLine("Hello From Person");
        }
    }
    class Employee: Person
    {
        public string name;
        public sealed override void Display()
        {
            Console.WriteLine("Hello from employee");
        }
    }
    class PartTime : Employee
    {
       /*
       'PartTime.Display()': cannot override inherited member 'Employee.Display()' because it is sealed	

        public override void Display() 
        {
            Console.WriteLine("Hello from PartTime Employee");
        }
       */
        
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
        }
    }
}
