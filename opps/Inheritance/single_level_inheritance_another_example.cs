using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_level_inheritance_another_example
{
    public class Person
    {
        public string Name;
        public string Address;
    }
    public class  Student:Person
    { 
        public int RollNo;
        public float Marks;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student();
            stud.Name = "Trish";
            stud.Address = "Nagpur";
            stud.RollNo = 32;
            stud.Marks = 82.63f;

            Console.WriteLine("Name :- " + stud.Name);
            Console.WriteLine("Address :- " + stud.Address);
            Console.WriteLine("Roll No. :- " + stud.RollNo);
            Console.WriteLine("Marks :- " + stud.Marks);
            Console.ReadKey();
        }
    }
}
