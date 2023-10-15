using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace total_marks_calculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, s3;
            float per;
            int total;
            string grade;

            Console.WriteLine("Enter subject 1 Marks :");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter subject 2 Marks :");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter subject 3 Marks :");
            s3 = Convert.ToInt32(Console.ReadLine());

            total = s1 + s2 + s3;
            Console.WriteLine("Total Marks =" + total);

            per = (total / 300.0f) * 100.0f;
            Console.WriteLine("Percentage =" + per);

            if (per >= 75)
            {
                grade = "Destinction";
            }
            else if (per >= 60 && per < 75)
            {
                grade = "First Class";
            }
            else
            {
                grade = "Failed";
            }

            Console.WriteLine("Grade =" + grade);
            Console.ReadKey();
        }
    }
}
