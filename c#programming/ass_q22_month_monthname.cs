using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_q22_month_monthname
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month;
            string monthname = null;

            Console.WriteLine("Enter the Month Number");
            month = Convert.ToInt32(Console.ReadLine());

            if(month == 1)
            {
                monthname = "January";
            }
            else if(month == 2)
            {
                monthname = "Fabruary";
            }
            else if (month == 3)
            {
                monthname = "March";
            }
            else if (month == 4)
            {
                monthname = "April";
            }
            else if (month == 5)
            {
                monthname = "May";
            }
            else if (month == 6)
            {
                monthname = "June";
            }
            else if (month == 7)
            {
                monthname = "July";
            }
            else if (month == 8)
            {
                monthname = "August";
            }
            else if (month == 9)
            {
                monthname = "September";
            }
            else if (month == 10)
            {
                monthname = "Octomber";
            }
            else if (month == 11)
            {
                monthname = "November";
            }
            else if (month == 12)
            {
                monthname = "December";
            }
            else
            {
                Console.WriteLine("Invalid ! Months");
            }

            Console.WriteLine(monthname);
            Console.ReadKey();
        }
    }
}
