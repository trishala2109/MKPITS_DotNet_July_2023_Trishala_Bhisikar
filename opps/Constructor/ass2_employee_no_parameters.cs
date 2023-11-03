using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_details_no_parameters_ass2
{
    internal class Program
    {
        class Employee
        {
            int EmployeeId;
            string EmployeeName;
            string Designation;
            int Salary;

            public Employee() 
            {
                EmployeeId = 123;
                EmployeeName = "Sujit";
                Designation = "Manager";
                Salary = 80000;
            }

            public void display()
            {
                Console.WriteLine("\n--------- Employee Details ----------\n");
                Console.WriteLine("Employee ID: " +  EmployeeId);
                Console.WriteLine("Employee Name: " + EmployeeName);
                Console.WriteLine("Designation: " + Designation);
                Console.WriteLine("Salary: " +  Salary);
            }
        }
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.display();

            Console.ReadKey();
        }
    }
}
