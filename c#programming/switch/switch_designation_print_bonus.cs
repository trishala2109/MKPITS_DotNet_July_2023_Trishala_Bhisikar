using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_designation_print_bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string designation;
            int bonus=0;

            Console.WriteLine("Enter the Designation (manger, cleark,peon) ");
            designation = Console.ReadLine();

            switch(designation)
            {
                case "maneger":
                    bonus = 10000;
                    break;
                case "clerk":
                    bonus = 5000;
                    break;
                case "peon":
                    bonus = 2000;
                    break;
                default:
                    Console.WriteLine("Invalid Designation");
                    break;
            }

            Console.WriteLine("Bonus {0}", bonus);
            Console.ReadKey();
        }
    }
}
