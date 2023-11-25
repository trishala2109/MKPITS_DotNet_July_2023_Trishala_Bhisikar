using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Stack_Employee
{
    class Employee
    {
        public int EmployeeID;
        public string Name;
        public string Designation;
        public int Salary;
        public Employee(int EmployeeID,string Name,string Designation,int Salary)
        {
            this.EmployeeID = EmployeeID;
            this.Name = Name;
            this.Designation = Designation;
            this.Salary = Salary;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(6931, "Amit", "Maneger", 50000);
            Employee emp2 = new Employee(9642, "Pooja", "Clerk", 20000);
            Employee emp3 = new Employee(7894, "Leela", "HR", 15000);
            Employee emp4 = new Employee(3331, "Sumit", "Assistant", 3000);

            Stack st = new Stack();
            st.Push(emp1);
            st.Push(emp2);
            st.Push(emp3);
            st.Push(emp4);

            Console.WriteLine("-------Before Poping-------");
            Console.WriteLine();
            foreach (Employee emp in st)
            {
                Console.WriteLine("Employee ID : " + emp.EmployeeID);
                Console.WriteLine("Employee Name : " + emp.Name);
                Console.WriteLine("Designation : " + emp.Designation);
                Console.WriteLine("Salary : " + emp.Salary);
                Console.WriteLine();
            }

            st.Pop();
            Console.WriteLine("-------After Poping-------");
            Console.WriteLine();
            foreach (Employee emp in st)
            {
                Console.WriteLine("Employee ID : " + emp.EmployeeID);
                Console.WriteLine("Employee Name : " + emp.Name);
                Console.WriteLine("Designation : " + emp.Designation);
                Console.WriteLine("Salary : " + emp.Salary);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
