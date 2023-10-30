using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_clone_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 5, 10 };
            int[] array2 = new int [3];

            Array.Copy(array1, array2, array1.Length);

            for(int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }
            Console.ReadKey();
        }
    }
}
