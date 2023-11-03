using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass3_emp_details_with_parameters_and_without_para
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
                Salary = 50000;
            }

            public Employee(int employeeId, string employeeName, string designation, int salary)
            {
                EmployeeId = employeeId;
                EmployeeName = employeeName;
                Designation = designation;
                Salary = salary;
            }

            public void display()
            {
                Console.WriteLine("\n---------------------------\n");
                Console.WriteLine("Employee ID: " + EmployeeId);
                Console.WriteLine("Employee Name: " + EmployeeName);
                Console.WriteLine("Designation: " +  Designation);
                Console.WriteLine("Salary: " + Salary);
              
            }
        }
        static void Main(string[] args)
        {
           
            Employee employee = new Employee();
            employee.display();

            Console.WriteLine("\n---------- Employee Details ---------\n");

            Console.WriteLine("Enter Employee ID: ");
            int empid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name: ");
            string empname = Console.ReadLine();

            Console.WriteLine("Enter Designation: ");
            string des = Console.ReadLine();

            Console.WriteLine("Enter Salary: ");
            int sal = Convert.ToInt32(Console.ReadLine());

            Employee employee1 = new Employee(empid, empname, des, sal);
            employee1.display();

            Console.ReadKey();
        }
    }
}
