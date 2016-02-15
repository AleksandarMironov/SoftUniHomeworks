using System;


namespace _01NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        static void Main()
        {
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            }
            while (n < 1);
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
