using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal_Access_modifier
{
    class Student
    {
        internal int RollNo;
        internal string Name;
        internal void getData(int RollNo,string Name)
        {
            this.RollNo = RollNo;
            this.Name = Name;
        }
        internal void displayData()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Roll No : " + RollNo);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.Write("Enter Name :- ");
            string name = Console.ReadLine();
            Console.Write("Enter Roll No. :- ");
            int rollno = Convert.ToInt32(Console.ReadLine());
            s.getData(rollno, name);
            s.displayData();
            Console.ReadKey();
        }
    }
}
