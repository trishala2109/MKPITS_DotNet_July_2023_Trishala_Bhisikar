using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1_store_element_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[10];
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write("element " + i + " ");
                
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < number.Length; i++)
            {
               
                Console.Write(number[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
