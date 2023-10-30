using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3_sum_of_all_array_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write("element - " + i + " ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                sum = sum + array[i];
            }
            Console.WriteLine("Sum of all elements stored in the array is : " + sum);
            Console.ReadKey();
        }
    }
}
