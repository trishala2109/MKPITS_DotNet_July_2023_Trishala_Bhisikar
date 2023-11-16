using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected_access_modifier
{
    class Person
    {
        string Name;
        string Address;
        protected void getPersonData(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }
        protected void displayPersonData()
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
            getPersonData("Rani", "Mumabi");
            this.Salary = Salary;
            this.Designation = Desigantion;
        }
        public void displayEmployeeData()
        {
            displayPersonData();
            Console.WriteLine("Salary :- " + Salary);
            Console.WriteLine("Designation :- " + Designation);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.getEmployeeData(20000, "Clerk");            
            emp.displayEmployeeData();
            Console.ReadKey();
        }
    }
}


