using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_q20_days_daysname
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day;
            string dayname = null;

            Console.WriteLine("Enter the Day Number");
            day = Convert.ToInt32(Console.ReadLine());

            if (day == 1)
            {
                dayname = "Monday";
            }
            else if (day == 2)
            {
                dayname = "Tuesday";
            }
            else if (day == 3)
            {
                dayname = "Wednesday";
            }
            else if (day == 4)
            {
                dayname = "Thursday";
            }
            else if (day == 5)
            {
                dayname = "Friday";
            }
            else if (day == 6)
            {
                dayname = "Saturday";
            }
            else if (day == 7)
            {
                dayname = "Sunday";
            }
            else
            {
                Console.WriteLine("Invalid Number !");
            }

            Console.WriteLine(dayname);
            Console.ReadKey();
        }
    }
}
