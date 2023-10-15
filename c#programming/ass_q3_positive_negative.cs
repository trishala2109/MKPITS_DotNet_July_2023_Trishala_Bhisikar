using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_q3_positive_negative_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter the Number ");
            num = Convert.ToInt32(Console.ReadLine());

            if(num>0)
            {
                Console.WriteLine("The Number are positive");
            }
            else
            {
                Console.WriteLine("The Number are negative");
            }
            Console.ReadKey();
        }
    }
}
