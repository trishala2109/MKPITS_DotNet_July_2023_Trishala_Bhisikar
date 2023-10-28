using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q9_odd_and_even_number_seprate_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Input the number of elements to be stored in the array : ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] array1 = new int[n];
            int[] array2 = new int[n];
            int[] array3 = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("element - " + i + " ");
                array1[i] = Convert.ToInt32(Console.ReadLine());

            }
            int j = 0;
            int k = 0;

            for( int i = 0; i < n; i++)
            {
                if (array1[i] % 2 == 0)
                {
                    array2[j] = array1[i];
                    j++;
                }
                else
                {
                    array3[k] = array1[i];
                    k++;
                }
            }

            Console.WriteLine("Even Nmbers");

            for( int i = 0; i < j; i++)
            {
                Console.Write( array2[i]);
            }

            Console.WriteLine("\nOdd Nmbers");

            for (int i = 0; i < k; i++)
            {
                Console.Write(array3[i]);
            }
            Console.ReadKey();
        }
    }
}
