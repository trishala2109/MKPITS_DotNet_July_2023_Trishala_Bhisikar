using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel_Inheritance
{
    public class Person
    {
        string Name;
        string Address;

        public void getPersonData(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }
        public void displayPersonData()
        {
            Console.WriteLine("Name :- " + Name);
            Console.WriteLine("Address :- " + Address);
        }
    }
    public class Employee:Person
    {
        int Salary;
        string Designation;
        public void getEmployeeData(int Salary, string Desigantion)
        {
            this.Salary = Salary;
            this.Designation = Desigantion;
        }
        public void displayEmployeeData()
        {
            Console.WriteLine("Salary :- " + Salary);
            Console.WriteLine("Designation :- " + Designation);
        }
    }
    public class PratTimeEmployee:Employee
    {
        int Hours;
        public void getPartTimeEmployeeData(int Hours)
        {
            this.Hours = Hours;
        }
        public void displayPartTimeEmployeeData()
        {
            Console.WriteLine("Time Duration of working :- " + Hours);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PratTimeEmployee emp = new PratTimeEmployee();
            emp.getPersonData("Trish", "Nagpur");
            emp.getEmployeeData(50000, "Maneger");
            emp.getPartTimeEmployeeData(5);
            emp.displayPersonData();
            emp.displayEmployeeData();
            emp.displayPartTimeEmployeeData();
            Console.ReadKey();
        }
    }
}
