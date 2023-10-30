using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q7_frequency_of_an_element_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Input the number of elements to be stored in the array : ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];
            int[] freq = new int[n];
            int count = 0;

            for(int i = 0; i < n; i++)
            {
                Console.Write("element - " + i + " ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                freq[i] = 1;
            }
            for( int i = 0; i < n; i++)
            {
                count = 1;
                for( int j = i+1; j < n; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                        freq[j] = 0;
                    }
                    if (freq[i] != 0)
                    {
                        freq[i] = count;
                    }
                }

            }
            for (int i = 0; i < n; i++)
            {
                if (freq[i] != 0)
                {
                    Console.WriteLine("{0} occure in {1} time", array[i], freq[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
