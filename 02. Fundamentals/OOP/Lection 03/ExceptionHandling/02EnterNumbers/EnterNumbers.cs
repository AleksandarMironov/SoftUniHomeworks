using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02EnterNumbers
{
    internal class EnterNumbers
    {
        private static void Main()
        {
            int start = 1;
            int end = 100;
            int counter = 0;
            int num = 0;
            int[] numbers = new int[10];

            while (counter < 10)
            {
                try
                {
                    num = ReadNumbers(start, end);
                    start = num;
                    numbers[counter] = num;
                    counter++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number!");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("The number is not in the requested range!");
                }
            }
            Console.WriteLine("Good job!");
        }

        public static int ReadNumbers(int start, int end)
        {
            Console.WriteLine("Enter a number between {0} and {1}: ", start, end);
            int num = int.Parse(Console.ReadLine());

            if (num <= start || num >= end)
            {
                throw new ArgumentException("The number is not in the requested range!");
            }

            return num;
        }
    }
}
