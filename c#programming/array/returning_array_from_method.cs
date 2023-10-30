using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace returning_array_from_method
{
    internal class Program
    {
        static int [] returnvalue()
        {
            int[] number = { 1, 5, 9 };
            return number;
        }
        static void Main(string[] args)
        {
            int[] result = returnvalue();
            for(int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.ReadKey();
        }
    }
}
