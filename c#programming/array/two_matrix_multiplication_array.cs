using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_matrix_multiplication_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = { { 5, 6 }, { 9, 6 } };
            int[,] array2 = { { 9, 6 }, { 10, 7 } };
            int [,] array3 = new int [2, 2];

            for(int row = 0; row < 2; row ++)
            {
                for (int col = 0; col < 2; col ++)
                {
                    array3[row, col] = array1[row, col] * array2[row, col];
                }
            }
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(array3[row, col] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
