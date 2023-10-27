using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4_copy_one_array_into_another
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[3];
            int[] array2 = new int[3];

            for( int i = 0; i <= 2; i++)
            {
                Console.Write("element - " + i + " ");
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for( int i = 0; i <= 2; i++)
            {
                array2[i] = array1[i];
            }

            Console.WriteLine("The elements stored in the first array are :");
            for (int i = 0; i <= 2; i++)
            {
                Console.Write(array1[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("The elements copied into the second array are :");
            for (int i = 0; i <= 2; i++)
            {
                Console.Write(array2[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
