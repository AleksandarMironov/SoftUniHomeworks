using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06CountSymbols
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char[] chars = new char[input.Length];
            chars = input.ToCharArray();
            Array.Sort(chars);
            int letterCount = 1;
            for (int i=1; i<chars.Length; i++)
            {
                if (chars[i]==chars[i-1])
                {
                    letterCount++;
                    if (i == chars.Length-1)
                    {
                        Console.WriteLine("{0}: {1} time/s", chars[i], letterCount);
                    }
                    continue;
                }
                if (chars[i]!=chars[i-1])
                {
                    Console.WriteLine("{0}: {1} time/s", chars[i-1], letterCount);
                    letterCount = 1;
                    if (i == chars.Length-1)
                    {
                        Console.WriteLine("{0}: {1} time/s", chars[i], letterCount);
                    }
                }
            }
        }
    }
}
