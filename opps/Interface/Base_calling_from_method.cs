using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_calling_from_method
{
    class Company
    {
        public string Name = "Haldiram";
        public void Display()
        {
            Console.WriteLine("Company Name : " + Name);
        }
    }
    class Franchisi:Company
    {
        public string Name = "Day-To-Day";
        public void Display()
        {
            base.Display();
            Console.WriteLine("Franchisis of the Company name is : " + Name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Franchisi f = new Franchisi();
            f.Display();
            Console.ReadLine();
        }
    }
}
