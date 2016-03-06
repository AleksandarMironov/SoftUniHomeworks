using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05LongestIncreasingSequence
{
    class LongestIncreasingSequence
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int[] mass = input.Split().Select(int.Parse).ToArray();
            int sequenceLength = 1;
            int biggestSequence = 1;
            int lastElement = 0;
            Console.Write(mass[0] + " ");
            for (int i = 1; i<mass.Length; i++)
            {
                if (mass[i] <= mass[i-1])
                {
                    Console.WriteLine();
                    sequenceLength = 1;
                }
                if (mass[i] > mass[i-1])
                {
                    sequenceLength++;
                    lastElement = i;
                }
                if (sequenceLength>biggestSequence)
                {
                    biggestSequence = sequenceLength;
                }
                Console.Write(mass[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Longest: ");

            for (int i = lastElement-biggestSequence+1; i<=lastElement; i++)
            {
                Console.Write(mass[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
