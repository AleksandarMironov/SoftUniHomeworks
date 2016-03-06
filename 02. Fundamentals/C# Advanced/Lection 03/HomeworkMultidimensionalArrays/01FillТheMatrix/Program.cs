using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01FillТheMatrix
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter size:");
            int n = int.Parse(Console.ReadLine());

            /// Pattern A
            int [,] massA = new int [n,n];
            int count = 1;
            for (int i = 0; i<n; i++)
            {
                for (int j = 0; j<n; j++)
                {
                    massA[j, i] = count;
                    count++;
                }
            }

            /// Pattern B
            int[,] massB = new int[n, n];
            count = 1;
            for (int i = 0; i<n; i++)
            {
                if (i%2==0)
                {
                    for (int j = 0; j<n; j++)
                    {
                        massB[j, i] = count;
                        count++;
                    }
                }
                else if (i % 2 != 0)
                {
                    for (int j = n-1; j >= 0; j--)
                    {
                        massB[j, i] = count;
                        count++;
                    }
                }
            }

            Console.WriteLine("Pattern A");
            for (int i = 0; i<n; i++)
            {
                for (int j =0; j<n; j++)
                {
                    Console.Write(massA[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Pattern B");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(massB[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
