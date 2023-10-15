using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace total_percentage_division_of_student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int phy, chem, compu,rno;
            float per;
            int total;
            string grade,name;

            Console.Write("Roll No :");
            rno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name of Student :");
            name = Console.ReadLine();
            Console.Write("Marks in Physics :  ");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Marks in Chemistry : ");
            chem = Convert.ToInt32(Console.ReadLine());
            Console.Write("Marks in Computer Application : ");
            compu = Convert.ToInt32(Console.ReadLine());

            total = phy + chem + compu;
            Console.WriteLine("Total Marks =" + total);

            per = (total / 300.0f) * 100.0f;
            Console.WriteLine("Percentage =" + per);

            if (per >= 75)
            {
                grade = "First";
            }
            else if (per >= 60 && per < 75)
            {
                grade = "Second";
            }
            else if(per>=50 && per <60)
            {
                grade = "Third";
            }
            else
            {
                grade = "failed";
            }

            Console.WriteLine("Division =" + grade);
            Console.ReadKey();
        }
    }
}

