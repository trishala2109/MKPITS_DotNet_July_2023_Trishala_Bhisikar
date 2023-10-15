using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_q19_grade_description
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char grade;
            string description =null ;

            Console.Write("Input the Grade :");
            grade = Convert.ToChar(Console.ReadLine());

            if(grade == 'E')
            {
                description = "Excellent";
            }
            else if(grade == 'V')
            {
                description = "Very Good";
            }
            else if (grade == 'G')
            {
                description = "Good";
            }
            else if (grade == 'A')
            {
                description = "Average";
            }
            else if(grade == 'F')
            {
                description = "Fail";
            }
            else
            {
                Console.WriteLine("It is inavlid !");
            }
            Console.WriteLine( description);
            Console.ReadKey();
        }
    }
}
