using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_q24_geometrical_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length, side, breadth, area = 0, choice;
            float radius;

            Console.WriteLine("1. Calculate the area of a circle");
            Console.WriteLine("2. Calculate the area of a square");
            Console.WriteLine("3. Calculate the area of a rectangle");

            Console.Write("Input your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if(choice == 1)
            {
                Console.Write("Input radius of the circle: ");
                radius = Convert.ToSingle(Console.ReadLine());
                area = (int) (3.14f * radius * radius);
            }
            else if (choice == 2)
            {
                Console.Write("Input side length of the square: ");
                side = Convert.ToInt32(Console.ReadLine());
                area = side * side;
            }
            else if(choice == 3)
            {
                Console.Write("Input length of the rectangle: ");
                length = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input breadth of the rectangle: ");
                breadth = Convert.ToInt32(Console.ReadLine());
                area = length * breadth;
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
            Console.WriteLine("The Area is :" +area);
            Console.ReadKey();
        }
    }
}
