using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07CalculateCombinations
{
    class CalculateCombinations
    {
        static void Main()
        {
            int n;
            int k;
            Console.WriteLine("Enter n & k (1 < k < n < 100)");
            do
            {
                n = int.Parse(Console.ReadLine());
                k = int.Parse(Console.ReadLine());
            }
            while (n <= 1 || n >= 100 || n <= k || k <= 1 || k >= 100);
            long answer = 1;
            for (int i = k + 1; i <= n; i++) ///n>k by defoult
            {
                answer = answer * i;
            }
        }
    }
}
