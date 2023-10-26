using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_the_number_an_arry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter number");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                sum = sum + num[i];

            }
            Console.WriteLine("sum of array elements = {0}", sum);

            Console.ReadKey();

        }
    }
}
