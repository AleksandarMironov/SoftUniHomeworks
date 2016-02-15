using System;


namespace Sunglasses
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i1 = 0; i1 < 2 * n; i1++)
            {
                Console.Write("*");
            }
            for (int i2 = 0; i2 < n; i2++)
            {
                Console.Write(" ");
            }
            for (int i3 = 0; i3 < 2 * n; i3++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
            for (int i4 = 0; i4 < n - 2; i4++)
            {
                Console.Write("*");
                for (int i5 = 0; i5 < 2 * n - 2; i5++)
                {
                    Console.Write("/");
                }
                Console.Write("*");
                if (i4 == ((n - 3) / 2))
                {
                    for (int i6 = 0; i6 < n; i6++)
                    {
                        Console.Write("|");
                    }
                }
                else
                {
                    for (int i7 = 0; i7 < n; i7++)
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("*");
                for (int i9 = 0; i9 < 2 * n - 2; i9++)
                {
                    Console.Write("/");
                }
                Console.Write("* \n");

            }
            for (int i10 = 0; i10 < 2 * n; i10++)
            {
                Console.Write("*");
            }
            for (int i11 = 0; i11 < n; i11++)
            {
                Console.Write(" ");
            }
            for (int i12 = 0; i12 < 2 * n; i12++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}