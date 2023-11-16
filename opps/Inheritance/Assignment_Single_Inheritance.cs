using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Single_Inheritance
{
    public class Person
    {
        public string Name;
        public string Address;
    }
    public class  Employee : Person
    {
        public int empno;
        public int Salary;
        public string Designation;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Name = "Asmita";
            emp.Address = "Mumbai";
            emp.empno = 59624;
            emp.Salary = 50000;
            emp.Designation = "Maneger";

            Console.WriteLine("Name :- " + emp.Name);
            Console.WriteLine("Address :- " + emp.Address);
            Console.WriteLine("Employee No. :- " + emp.empno);
            Console.WriteLine("Salary :- " + emp.Salary);
            Console.WriteLine("Designation :- "+ emp.Designation);
            Console.ReadKey();
        }
    }
}
