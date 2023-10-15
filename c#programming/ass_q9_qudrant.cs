using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_q9_qudrant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter the value x");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value y");
            y = Convert.ToInt32(Console.ReadLine());

            if(x>0 && y>0)
            {
                Console.WriteLine("The coordinate point lies"+(x,y)+" in the First quadrant.");
            }
            else if(x<0 && y>0)
            {
                Console.WriteLine("The coordinate point lies"+(x,y)+" in the Second quadrant.");
            }
            else if(x<0 && y<0)
            {
                Console.WriteLine("The coordinate point lies " +(x,y)+ "in the Third quadrant.");
            }
            else if (x>0 && y<0)
            {
                Console.WriteLine("The coordinate point lies"+(x,y)+" in the Fourth quadrant.");
            }
            Console.ReadKey();
        }
    }
}
