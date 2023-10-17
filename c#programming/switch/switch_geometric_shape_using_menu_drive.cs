using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_geometric_shape_using_menu_drive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length, breadth, side, choice;
            double radius,result=0;

            Console.WriteLine("1. Area of Reactangle");
            Console.WriteLine("2. Area of Circle");
            Console.WriteLine("3. Area of Square");

            Console.WriteLine("Enter Your Choice");
            choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter the Length");
                    length = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Breadth");
                    breadth = Convert.ToInt32(Console.ReadLine());
                    result = length * breadth;
                    break;
                case 2:
                    Console.WriteLine("Enter radius");
                    radius = Convert.ToDouble(Console.ReadLine());
                    result = 2 * 3.14 * radius * radius;
                    break;
                case 3:
                    Console.WriteLine("Enter Side");
                    side = Convert.ToInt32(Console.ReadLine());
                    result = 4 * side;
                    break;
                default:
                    Console.WriteLine("invalid Choice");
                    break;
            }
            Console.WriteLine("Result = {0}", result);
            Console.ReadKey();
        }
    }
}
