using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_level_Inheritance
{
    public class Employee
    {
        public int Salary=10000;
    }

    public class Programmner:Employee
    {
        public int Bonus=2000;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Programmner pr = new Programmner();
           
            Console.WriteLine("Salary :- " + pr.Salary);
            Console.WriteLine("Bonus :- " + pr.Bonus);
            Console.ReadKey();
        }
    }
}
