using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c;
            int[] mass = new int[n];
            for (int i = 0; i < n; i++)
            {
                mass[i] = a;
                Console.Write("{0} ", mass[i]);
                c = a + b;
                a = b;
                b = c;
            }
        }
    }
}
