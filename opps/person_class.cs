using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person_class
{
    class Person
    {
        string name;
        int age;
        string address;

        public void getData(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }
        public void displayData()
        {
            Console.WriteLine("Person Name :- " + name);
            Console.WriteLine("Person Age :- " + age);
            Console.WriteLine("Person Address :- " + address);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person per = new Person();
            Console.Write("Enter name :-");
            string n = Convert.ToString(Console.ReadLine());

            Console.Write("Enter Age :- ");
            int ag = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Address :- ");
            string ad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("---------------------------------------");

            per.getData(n, ag, ad);
            per.displayData();
            Console.ReadKey();
        }
    }
}
