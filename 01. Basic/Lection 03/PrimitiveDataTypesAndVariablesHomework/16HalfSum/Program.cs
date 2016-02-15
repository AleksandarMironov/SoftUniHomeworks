using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16HalfSum
{
    class Program
    {
        static void Main()
        {
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
                if (n > 500 || n < 0)
                {
                    Console.WriteLine("enter again");
                }
            }
            while (n > 500 || n < 0);
            int[] mass1 = new int[n];
            int[] mass2 = new int[n];
            for (int i = 0; i < n; i++)
            { 
                mass1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                mass2[i] = int.Parse(Console.ReadLine());
            }
            int sum1=0;
            int sum2=0;
            for (int i = 0; i < n; i++)
            {
                sum1 = sum1 + mass1[i];
            }
            for (int i = 0; i < n; i++)
            {
                sum2 = sum2 + mass2[i];
            }
            if (sum1 == sum2)
            {
                Console.WriteLine("Yes, sum={0}", sum1);
            }
            else
            {
                int dif = sum1 - sum2;
                Console.WriteLine("No, diff={0}", Math.Abs (dif));
            }
        }
    }
}