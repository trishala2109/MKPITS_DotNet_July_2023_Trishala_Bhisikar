using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_q2_no_even_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter the Number :-");
            num = Convert.ToInt32(Console.ReadLine());

            if(num%2==0)
            {
                Console.WriteLine("The Number is Even");
            }
            else
            {
                Console.WriteLine("The Number is Odd");
            }
            Console.ReadKey();
        }
    }
}
