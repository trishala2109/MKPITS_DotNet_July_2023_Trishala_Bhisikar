using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q8_maximum_and_minimum_element_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Input the number of elements to be stored in the array : ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];
            
            for(int i = 0; i < n; i++)
            {
                Console.Write("element - " + i + " ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = array[0], min = array[0];
            for (int i = 1; i < n; i ++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            Console.WriteLine("Maximum element is : " + max);
            Console.WriteLine("Minimum element is : " + min);
            Console.ReadLine();
        }
    }
}
