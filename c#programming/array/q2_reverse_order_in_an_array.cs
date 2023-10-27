using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2_reverse_order_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[3];
            int temp;

            for (int i =0; i <= 2; i++)
            {
                Console.Write("element " + i + " ");
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The values store into the array are:");
            for (int i = 0; i <= 2; i++)
            {
                Console.Write(number[i] + " ");
            }
            
            Console.WriteLine();
            Console.WriteLine("The values store into the array in reverse are :");
            for( int i = 2; i >= 0; i--)
            {
                Console.Write(number[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
