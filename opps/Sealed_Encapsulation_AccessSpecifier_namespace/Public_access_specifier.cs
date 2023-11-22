using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public_access_specifier
{
    class Student
    {
        public string Name;
        public void display()
        {
            Console.WriteLine("Name : " + Name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "Vishakha";
            s.display();
            Console.ReadLine();
        }
    }
}
