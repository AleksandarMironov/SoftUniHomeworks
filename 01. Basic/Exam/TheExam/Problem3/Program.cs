using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(new string ('.', (3*n+2)/2));
            Console.Write("*");
            Console.WriteLine(new string('.', (3 * n + 2) / 2));
            for (int i = 1; i<=n; i=i+2)
            {
                Console.Write(new string('.', (3 * n -i) / 2));
                Console.Write("*");
                Console.Write(new string('.', i));
                Console.Write("*");
                Console.WriteLine(new string('.', (3 * n -i) / 2));
            }
            Console.Write(new string('*', n));
            Console.Write(new string('.', n + 2)); 
            Console.WriteLine(new string('*', n));
            for (int i2 = 1; i2<n/2+1; i2++)
            {
                Console.Write(new string('.', i2));
                Console.Write("*");
                Console.Write(new string('.', 3*n-2*i2));
                Console.Write("*");
                Console.WriteLine(new string('.', i2));
            }
            for (int i3= n/2-1, i4=0; i3>=0; i3--, i4++)
            {
                Console.Write(new string('.', i3));
                Console.Write("*");
                Console.Write(new string('.', n/2));
                Console.Write("*");
                Console.Write(new string('.', i4));
                Console.Write("*");
                Console.Write(new string('.', n));
                Console.Write("*");
                Console.Write(new string('.', i4));
                Console.Write("*");
                Console.Write(new string('.', n / 2));
                Console.Write("*");
                Console.WriteLine(new string('.', i3));
            }
            Console.Write(new string('*', n / 2+1));
            Console.Write(new string('.', n / 2));
            Console.Write("*");
            Console.Write(new string('.', n));
            Console.Write("*");
            Console.Write(new string('.', n / 2));
            Console.WriteLine(new string('*', n / 2 + 1));
            for (int i5 = 0; i5<n; i5++)
            {
                Console.Write(new string('.', n));
                Console.Write("*");
                Console.Write(new string('.', n));
                Console.Write("*");
                Console.WriteLine(new string('.', n));
            }
            Console.Write(new string('.', n));
            Console.Write(new string('*', n+2));
            Console.WriteLine(new string('.', n));

        }
    }
}
