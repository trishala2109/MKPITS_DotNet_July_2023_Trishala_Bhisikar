using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_student_Arrary_Collection
{
    class Student
    {
        public int RollNo;
        public string Name;
        public Student(int RollNo,string Name)
        {
            this.RollNo = RollNo;
            this.Name = Name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(11, "Sumit");
            Student s2 = new Student(12, "pooja");
            Student s3 = new Student(13, "Delip");
            Student s4 = new Student(14, "Aish");

            ArrayList ar = new ArrayList();
            ar.Add(s1);
            ar.Add(s2);
            ar.Add(s3);
            ar.Add(s4);

            foreach(Student Stud in ar)
            {
                Console.WriteLine("Roll No. : " + Stud.RollNo);
                Console.WriteLine("Name : " + Stud.Name);
            }
            Console.ReadKey();
        }
    }
}
