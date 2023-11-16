using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protechted_access_modifire
{
    class Person
    {
        string Name;
        protected void getPersonData(string Name)
        {
            this.Name = Name;
            Console.WriteLine("Name :- " + Name);
        }
    }
    class Employee:Person
    {
        int empno;
        internal void getEmployeeData(int empno,string Name)
        {
            getPersonData(Name);
            this.empno = empno;
            Console.WriteLine("Employee NO. :- " + empno);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.getEmployeeData(56312,"Kiti");
            Console.ReadKey();
        }
    }
}
