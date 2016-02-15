using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03MinMaxSumAndAverageOfNNumbers
{
    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main()
        {
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                    Console.WriteLine("Enter positive integer!");
            }
            while (n <= 0);
            int[] mass = new int[n];
            int sum = 0;
            int min = Int32.MaxValue;
            int max = Int32.MinValue;
            for (int i = 0; i<n; i++)
            {
                mass[i] = int.Parse(Console.ReadLine());
                sum = sum + mass[i];
                min = Math.Min(min, mass[i]);
                max = Math.Max(max, mass[i]);

            }
            Console.WriteLine(" min= {0} \n\r max= {1} \n\r sum= {2} \n\r avg= {3:0.00}", min, max, sum, ((double)sum/n) );

        }
    }
}
