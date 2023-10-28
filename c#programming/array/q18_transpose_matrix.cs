using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q18_transpose_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Input the rows and columns of first matrix : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());

            int[,] array1 = new int[n1, n2];
            int[,] transpose = new int[n1, n2];
            int i = 0;
            int j = 0;

            Console.WriteLine("Input elements in the first matrix :");
            
            for (i = 0; i < n1; i++)
            {
                for (j = 0; j < n2; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    array1[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }

            Console.WriteLine("The matrix is :");
            for (i = 0; i < n1; i++)
            {
                for (j = 0; j < n2; j++)
                {
                    Console.Write(array1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for (i = 0; i < n1; i++)
            {
                for (j = 0; j < n2; j++)
                {
                    transpose[j, i] = array1[i, j];
                }
            }

            Console.WriteLine("The Transpose of a matrix is :");
            for (i = 0; i < n1; i++)
            {
                for (j = 0; j < n2; j++)
                {
                    Console.Write(transpose[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
