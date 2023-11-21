using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_base_class_interanally
{
    class Company
    {
        public string Name = "Haldiram";
        public Company()
        {
            Console.WriteLine("Calling Base class ");
            Console.WriteLine("Company Name : " + Name);
        }
    }
    class Franchisi : Company
    {
        public string Name = "Day-To-Day";
        public Franchisi()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Calling Derive class ");
            Console.WriteLine("Franchisis of the Company name is : " + Name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Franchisi f = new Franchisi();
            Console.ReadKey();
        }
    }
}
