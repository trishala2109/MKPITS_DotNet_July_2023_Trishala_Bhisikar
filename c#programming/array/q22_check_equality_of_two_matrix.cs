using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q22_check_equality_of_two_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
                int row = 0;
                int col = 0;

                Console.WriteLine("Input Rows and Columns of the 1st matrix : ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                int n2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nInput Rows and Columns of the 2st matrix : ");
                int n3 = Convert.ToInt32(Console.ReadLine());
                int n4 = Convert.ToInt32(Console.ReadLine());

                int[,] matrix1 = new int[n1, n2];
                int[,] matrix2 = new int[n3, n4];

                if (n1 == n3 && n2 == n4)
                {
                    Console.WriteLine("\nInput elements in the first matrix : \n");

                    for (row = 0; row < n1; row++)
                    {
                        for (col = 0; col < n2; col++)
                        {
                            Console.Write("Element [{0}],[{1}] : ", row, col);
                            matrix1[row, col] = Convert.ToInt32(Console.ReadLine());
                        }
                    }


                    Console.WriteLine("\nInput elements in the second matrix : \n");

                    for (row = 0; row < n3; row++)
                    {
                        for (col = 0; col < n4; col++)
                        {
                            Console.Write("Element [{0}],[{1}] : ", row, col);
                            matrix2[row, col] = Convert.ToInt32(Console.ReadLine());
                        }
                    }

                    Console.WriteLine("\nThe first matrix is :\n");

                    for (row = 0; row < n1; row++)
                    {
                        for (col = 0; col < n2; col++)
                        {
                            Console.Write(matrix1[row, col] + "\t");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("\nThe Second matrix is :\n");

                    for (row = 0; row < n3; row++)
                    {
                        for (col = 0; col < n4; col++)
                        {
                            Console.Write(matrix2[row, col] + "\t");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("\nThe Matrices can be compared: \n");
                    bool equal = true;

                    for (row = 0; row < n1; row++)
                    {
                        for (col = 0; col < n2; col++)
                        {
                            if (matrix1[row, col] != matrix2[row, col])
                            {
                                equal = false;
                                break;
                            }
                        }
                    }

                    if (equal)
                    {
                        Console.WriteLine("Two matrices are equal.");
                    }
                    else
                    {
                        Console.WriteLine("Two matrices are un-equal.");
                    }
                }

                else
                {
                    Console.WriteLine("\nInput Elements of the Matrices are not same.");
                }

                Console.ReadKey();
            }
        }
    }
