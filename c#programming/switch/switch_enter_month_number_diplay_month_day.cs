using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_enter_month_number_diplay_month_day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int monthNo;

            Console.WriteLine("Enter Month Number");
            monthNo = Convert.ToInt32(Console.ReadLine());

            switch (monthNo)
            {
                case 1:
                    Console.WriteLine("Month have 31 days");
                    break;
                case 2:
                    Console.WriteLine("Month have 28 & 29 days");
                    break;
                case 3:
                    Console.WriteLine("Month have 31 days");
                    break;
                case 4:
                    Console.WriteLine("Month have 30 days");
                    break;
                case 5:
                    Console.WriteLine("Month have 31 days");
                    break;
                case 6:
                    Console.WriteLine("Month have 30 days");
                    break;
                case 7:
                    Console.WriteLine("Month have 31 days");
                    break;
                case 8:
                    Console.WriteLine("Month have 31 days");
                    break;
                case 9:
                    Console.WriteLine("Month have 30 days");
                    break;
                case 10:
                    Console.WriteLine("Month have 31 days");
                    break;
                case 11:
                    Console.WriteLine("Month have 30 days");
                    break;
                case 12:
                    Console.WriteLine("Month have 31 days");
                    break;
                default:
                    Console.WriteLine("Invalid Month Number");
                    break;
            }
            Console.ReadKey();
        }
    }
}

