using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_student_using_array
{
    class Student
    {
        string name;
        int roll_no, total;
        float average;
       

        public void getData(string name, int roll_no,int total, float average)
        {
            this.name = name;
            this.roll_no = roll_no;
            this.total = total;
            this.average = average;
        }

        public void AverageMarks()
        {
            Console.WriteLine("Student Name :- " + name);
            Console.WriteLine("Student Roll no. :- " + roll_no);
            Console.WriteLine("Total of Marks :- " + total);
            Console.WriteLine("Average of Marks :- " + average);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student();
            int[] marks = { 50, 60, 40 };
            int tot = 0;
            
            for(int i = 0;i < marks.Length;i++)
            {
                tot = tot + marks[i];
            }

            int avg = tot / 3;

            stud.getData("Trish", 32, tot, avg);
            stud.AverageMarks();
            Console.ReadKey();
        }
    }
}
