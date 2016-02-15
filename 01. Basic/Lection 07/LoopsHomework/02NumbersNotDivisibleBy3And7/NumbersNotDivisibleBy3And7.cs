using System;


namespace _02NumbersNotDivisibleBy3And7
{
    class NumbersNotDivisibleBy3And7
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Enter positive integer:");
            do
            {
                n = int.Parse(Console.ReadLine());
            }
            while (n < 1);
            for (int i = 1; i<=n; i++)
            {
                if (i%3!=0)
                {
                    if (i%7!=0)
                    {
                        Console.Write(i +" ");
                    }
                }
            }
        }
    }
}
