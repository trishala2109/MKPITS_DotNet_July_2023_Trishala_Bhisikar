using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q17_multiplication_of_two_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            
            Console.WriteLine("Input the rows and columns of first matrix : ");
            n1=Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the rows and columns of second matrix : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());

            int[,] array1 = new int[n1, n2];
            int[,] array2= new int[n1, n2];
            int[,] array3 = new int[n1, n2];

            Console.WriteLine("Input elements in the first matrix :");
            int i = 0;
            int j = 0;

            for (i = 0; i < n1; i++)
            {
                for (j = 0; j < n2; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    array1[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }

            Console.WriteLine("Input elements in the second matrix :");

            for (i = 0; i < n1; i++)
            {
                for (j = 0; j < n2; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    array2[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }

            Console.WriteLine("The first matrix is :");
            for (i = 0; i < n1; i++)
            {
                for (j = 0; j < n2; j++)
                {
                    Console.Write(array1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("The second matrix is :");
            for (i = 0; i < n1; i++)
            {
                for (j = 0; j < n2; j++)
                {
                    Console.Write(array2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for (i = 0; i < n1; i++)
            {
                for (j = 0; j < n2; j++)
                {
                    array3[i, j] = array1[i, j] * array2[i, j];
                }
            }

            Console.WriteLine("The Multiplication of matrix is :");
            for (i = 0; i < n1; i++)
            {
                for (j = 0; j < n2; j++)
                {
                    Console.Write(array3[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
