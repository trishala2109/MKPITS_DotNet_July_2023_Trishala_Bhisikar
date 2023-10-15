using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_q23_enter_the_no_and_display_how_many_days_in_month
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day;
            Console.WriteLine("Enter Month Number ");
            day = Convert.ToInt32(Console.ReadLine());
            
            if( day == 1 || day == 3 || day == 5 || day == 7 || day == 8 || day == 10 || day == 12)
            {
                Console.WriteLine("Month have 31 days");
            }
            else if( day == 4 || day == 6 || day == 9 || day == 11 )
            {
                Console.WriteLine("Month have 30 days");
            }
            else if (day == 2)
            {
                Console.WriteLine("Month have 28 and 29 days");
            }
            else
            {
                Console.WriteLine("Inavlid Month Number");
            }
            Console.ReadLine();
        }
    }
}
