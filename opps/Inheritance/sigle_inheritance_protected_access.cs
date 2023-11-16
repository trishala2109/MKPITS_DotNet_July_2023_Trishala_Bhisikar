using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sigle_inheritance_protected_access
{
    class Employee
    {
        protected int Salary;
    }
    class Programmenr : Employee
    {
        public int Bonus;

        public void getData(int Salary ,int Bonus)
        {
            this.Salary = Salary;
            this.Bonus = Bonus;
        }
        public void displayData()
        {
            Console.WriteLine("Salary :- " + Salary);
            Console.WriteLine("Bonus :- " + Bonus);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Programmenr p = new Programmenr();
            p.getData(10000, 500);
            p.displayData();
            Console.ReadKey();
        }
    }
}
