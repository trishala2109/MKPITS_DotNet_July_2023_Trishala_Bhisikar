using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_q6_display_the_value_m_n
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m;
            Console.WriteLine("Enter the the value :-");
            m = Convert.ToInt32(Console.ReadLine());

            if(m>0)
            {
                Console.WriteLine("The Value of n = 1");
            }
            else
            {
                Console.WriteLine("The Value of n = -1");
            }
            Console.ReadKey();
        }
    }
}
