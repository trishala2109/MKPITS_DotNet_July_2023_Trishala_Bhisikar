using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_5_subject_marks_total
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int subject, counter;
            float per, total = 0;
            char grade;

            for(counter = 1; counter <= 5; counter++)
            {
                Console.WriteLine("Enter 5 Subject Marks");
                subject = Convert.ToInt32(Console.ReadLine());
                total =  total+subject;
            }

            Console.WriteLine("Total = {0}", total);

            per = (total / 500.0f) * 100.0f; 
            .Console.WriteLine("Percentage ={0}", per);

            if( per >= 75)
            {
                grade = 'A';
            }
            else if( per < 75 && per >= 60)
            {
                grade = 'B';
            }
            else if (per < 60 && per >= 45)
            {
                grade = 'C';
            }
            else
            {
                grade = 'F';
            }
            Console.WriteLine("Grade = {0}", grade);
            Console.ReadKey();
        }
    }
}
