using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q13_second_smallest_no_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,n1;
            Console.WriteLine("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());
            
            int[] array = new int[n];
            Array.Sort(array);

            for (int i = 0; i < n; i++)
            {
                Console.Write("element - " + i + " ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

                n1 = array.Length;
                Console.WriteLine("The Second smallest element in the array is : " + array[1]);
            
            Console.ReadKey();
        }
    }
}
