using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_ex
{
    class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int ID { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Name = "Vish";
            emp.Email = "Vish@gamil.com";
            emp.ID = 5631;
            Console.WriteLine("Name :- "+ emp.Name);
            Console.WriteLine("Email :- " + emp.Email);
            Console.WriteLine("ID :- " + emp.ID);
            Console.ReadLine();
        }
    }
}
