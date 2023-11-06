using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_student__having_parameters
{
    internal class Program
    {
        class Student
        {
            public int RollNo;
            public string Name;
            public string Course;
            public int Fees;

            public void getdata(int RollNo)
            {
                this.RollNo = RollNo;
            }

            public void getdata(int RollNo, string Name)
            {
                this.RollNo = RollNo;
                this.Name = Name;
            }

            public void getdata(int RollNo, string Name, string Course)
            {
                this.RollNo = RollNo;
                this.Name = Name;
                this.Course = Course;
            }

            public void getdata(int RollNo, string Name, string Course, int Fees)
            {
                this.RollNo = RollNo;
                this.Name = Name;
                this.Course = Course;
                this.Fees = Fees;
            }

            public void display()
            {
                Console.WriteLine("Roll No.: " + RollNo);
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Course: " + Course);
                Console.WriteLine("Fees: " + Fees);
            }
        }
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Console.WriteLine("\n-------- Student 1 ---------\n");
            student1.getdata(1);
            student1.display();

            Student student2 = new Student();
            Console.WriteLine("\n-------- Student 2 ---------\n");
            student2.getdata(1, "Trish");
            student2.display();

            Student student3 = new Student();
            Console.WriteLine("\n-------- Student 3 ---------\n");
            student3.getdata(1, "Trish", ".NET");
            student3.display();

            Student student4 = new Student();
            Console.WriteLine("\n-------- Student 4 ---------\n");
            student4.getdata(1, "Trish", ".NET", 5000);
            student4.display();

            Console.ReadKey();
        }
    }
}
