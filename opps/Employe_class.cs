using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employe_class
{
    class Employee
    {
        int emp_no;
        string emp_name;
        string emp_desig;
        int emp_salary;

        public void getData(int eno,string ename,string edes,int esal)
        {
            emp_no = eno;
            emp_name = ename;
            emp_desig = edes ;
            emp_salary = esal;
        }

        public void displayData()
        {
            Console.WriteLine("Employee No :- " + emp_no);
            Console.WriteLine("Employee Name :- " + emp_name);
            Console.WriteLine("Employee Designation :- " + emp_desig);
            Console.WriteLine("Employee Salary :- " + emp_salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.getData(563, "Trish", "Manager", 50000);
            emp.displayData();
            Console.ReadKey();
        }
    }
}
