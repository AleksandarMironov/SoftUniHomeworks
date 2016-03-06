using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02MaximalSum
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of matrix");
            Console.WriteLine("N=");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("M=");
            int m = int.Parse(Console.ReadLine());
            double [,] matrix = new double [n,m];
            for (int i =0; i<n; i++)
            {
                for (int j = 0; j<m; j++)
                {
                    Console.WriteLine("Element [{0},{1}]=",i,j);
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }
            double maxSum = double.MinValue;
            int startIndexOfMatrixI = 0;
            int startIndexOfMatrixJ = 0;

            for (int i = 0; i < n-2; i++)
            {
                for (int j = 0; j < m-2; j++)
                {
                    double tempSum = matrix[i, j] + matrix[i, j+1] + matrix[i, j+2] + matrix[i+1, j] + matrix[i+1, j+1] + matrix[i+1, j+2] + 
                        matrix[i+2, j] + matrix[i+2, j+1] + matrix[i+2, j+2];
                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                        startIndexOfMatrixI = i;
                        startIndexOfMatrixJ = j;
                    }
                }
            }
            Console.WriteLine("Sum = " + maxSum);
            for (int i = startIndexOfMatrixI; i < startIndexOfMatrixI+3; i++)
            {
                for (int j = startIndexOfMatrixJ; j < startIndexOfMatrixJ+3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
