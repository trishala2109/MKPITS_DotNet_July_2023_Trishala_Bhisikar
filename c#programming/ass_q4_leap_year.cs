using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_q4_leep_year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter the Year");
            year = Convert.ToInt32(Console.ReadLine());

            if(year%4==0)
            {
                Console.WriteLine("It is Leap Year");
            }
            else
            {
                Console.WriteLine("It is not Leap Year ");
            }
            Console.ReadKey();
        }
    }
}
