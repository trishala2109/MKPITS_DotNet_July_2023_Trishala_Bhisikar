using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q12_second_largest_number_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];
            
            for(int i = 0; i < n; i++)
            {
                Console.Write("elements - " + i + " ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(array);
            int n1 = array[array.Length - 2];
            Console.WriteLine("The Second largest element in the array is: "+ n1);
           
            Console.ReadKey();
        }
    }
}
