using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace employe_details
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int empno, basicsalary;
            string empname, designation;
            float bonus = 0, total = 0;

            Console.WriteLine("Enter Employe No. :");
            empno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employe Name :");
            empname =Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Basic Salary :");
            basicsalary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Designation :");
            designation = Convert.ToString(Console.ReadLine());

        
            if (designation == "manager")
            {
                bonus = basicsalary * 0.55f;
            }
            else if(designation== "clerk")
            {
                bonus = basicsalary * 0.25f;
            }
            else if (designation=="peon")
            {
                bonus = basicsalary * 0.10f;
            }
            else
            {
                Console.WriteLine("Invalid designation");
            }

            total = bonus + basicsalary;
            Console.WriteLine("\n");
            Console.WriteLine("Details: \n");
            Console.WriteLine(" Employe NO.: {0},\n Employee Name : {1}, \n Employee Basic Salary : {2}, \n Employee Designation :{3}" , empno , empname , basicsalary , designation);
            Console.WriteLine(" Bonus : {0},\n Calculate Basic Salary with Bonus : {1}" , bonus ,total);
            Console.ReadKey();
        }
    }
}
