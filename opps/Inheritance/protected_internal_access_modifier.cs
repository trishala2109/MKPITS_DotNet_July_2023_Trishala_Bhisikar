
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protected_internal_access_modifier
{
    class Person
    {
        string Name;
        string Address;
        protected internal void getPersonData(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }
        protected internal void displayPersonData()
        {
            Console.WriteLine("Name :- " + Name);
            Console.WriteLine("Address :- " + Address);
        }
    }
    class Employee : Person
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
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.getPersonData("Rani", "Mumabi");
            emp.getEmployeeData(20000, "Clerk");
            emp.displayPersonData();
            emp.displayEmployeeData();
            Console.ReadKey();
        }
    }
}

