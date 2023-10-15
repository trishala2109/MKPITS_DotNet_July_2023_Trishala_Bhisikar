using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_q7_peson_height
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height;

            Console.Write("Enter Height In Centimeter :");
            height = Convert.ToInt32(Console.ReadLine());

            if (height < 150)
            {
                Console.WriteLine("The person is Dwarf");
            }
            else
            {
                Console.WriteLine("The person is not a Dwarf");
            }
            Console.ReadKey();
        }
    }
}
