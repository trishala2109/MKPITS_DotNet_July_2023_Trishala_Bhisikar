using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Access_Modifier
{
    class Company
    {
        private string Company_Name="Haldiram";
        private string Francchise="Day-to-Day";
         private void displayData()  // you can use public access specifierto run this program
         { 
            Console.WriteLine("Company Name : " + Company_Name);
            Console.WriteLine("Francchise : " + Francchise);
         }
    }
     class Program
    {
        static void Main(string[] args)
        {
            Company c = new Company();
            c.displayData();  // 'Company.displayData()' is inaccessible due to its protection level
            Console.ReadLine();
        }
    }
}
