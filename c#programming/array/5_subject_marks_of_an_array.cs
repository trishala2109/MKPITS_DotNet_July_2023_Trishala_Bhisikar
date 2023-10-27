using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_subject_marks_of_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[5];
            int total = 0;
            float per=0;
            string grade;

            Console.Write("Enter 5 Subject Marks :- ");

            for (int i = 0; i < 5; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                total = total + marks[i];
                per = (total / 500.0f) * 100.0f;
            }
            Console.WriteLine("Total marks ={0} " , total);
            Console.WriteLine("Percentage ={0} ",  per);

            if (per >= 75)
                grade = "Distinction";
            else if (per >= 60 && per <= 75)
                grade = "First Class";
            else if (per >= 40 && per <= 60)
                grade = "Second Class";
            else
                grade = "Fail";
            Console.WriteLine("Grade = " + grade);
            Console.ReadKey();
        }
    }
}
