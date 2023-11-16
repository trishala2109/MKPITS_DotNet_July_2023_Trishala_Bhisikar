using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace single_inheritance_inherit_method_example
{
    public class Person
    {
        string Name;
        string Address;

        public void getPersonData(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }
        public void displayPersonData()
        {
            Console.WriteLine("Name :- " + Name);
            Console.WriteLine("Address :- " + Address);
        }
    }
    public class Student : Person
    {
        int RollNo;
        float Marks;
        public void getStudentData(int RollNo, int Marks)
        {
            this.RollNo = RollNo;
            this.Marks = Marks;
        }
        public void displayStudentData()
        {
            Console.WriteLine("Roll No. :- " + RollNo);
            Console.WriteLine("Marks :- " + Marks);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.getPersonData("Amit", "Bhopal");
            s.displayPersonData();
            s.getStudentData(32, 86);
            s.displayStudentData();
            Console.ReadKey();
        }
    }
}
