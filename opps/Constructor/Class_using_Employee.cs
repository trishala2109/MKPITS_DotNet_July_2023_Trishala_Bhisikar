using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Class_using_Employee
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public void getData(int EmployeeID, string Name, int Salary)
        {
            this.EmployeeID = EmployeeID;
            this.Name = Name;
            this.Salary = Salary;
        }

        public void display()
        {
            Console.WriteLine("Employee ID :- " + EmployeeID);
            Console.WriteLine("Employee Name :- " + Name);
            Console.WriteLine("Employee Salary :-" + Salary);
            Console.WriteLine("--------------------------------------");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[3];

            emp[0] = new Employee();
            emp[1] = new Employee();
            emp[2] = new Employee();

            int ID=0, salary=0;
            string nam=null;

            Console.WriteLine("Enter Employee Details ");
            for (int counter = 0; counter < 3; counter++)
            {
                Console.Write("Enter Employee ID :- ");
                ID = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Employee Name :- ");
                nam = Console.ReadLine();

                Console.Write("Employee Salary :- ");
                salary = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("--------------------------------------------");
                emp[counter].getData(ID, nam, salary);

            }
            
            int found = 0;
            int high = emp[0].Salary;

            for (int i = 0; i < 3; i++)
            {
                if (high < emp[i].Salary)
                {
                    high = emp[i].Salary;
                    found = i;
                }
            }
            Console.WriteLine("Employee with the Hightest Salary :");
            emp[found].display();

            Console.ReadKey();
        }
    }
}
