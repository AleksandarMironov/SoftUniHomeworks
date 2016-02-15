using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            int n = 0;
            string check = "";
            do
            {
            Console.WriteLine("Enter num: ");
            n = int.Parse(Console.ReadLine());
            Fib(n);
            Console.WriteLine("Do you want to enter next num? (Y/N)");
            check = Console.ReadLine().ToLower();
            }
            while (check != "n");

        }
        static void Fib(int n)
        {
            int[] mass = new int[n+2];
            mass[0] = 1;
            if (n>1)
            {
                mass[1] = 1;
            }
            if (n>2)
            {
                for (int i = 0; i<n; i++)
                {
                    mass[i + 2] = mass[i + 1] + mass[i];     
                }
            }
            Console.WriteLine(mass[n]);
        }
    }
}
