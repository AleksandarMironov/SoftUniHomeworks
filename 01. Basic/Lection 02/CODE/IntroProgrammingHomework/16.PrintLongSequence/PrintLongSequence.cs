using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main(string[] args)
        {
            Console.BufferHeight = 1005;
            int positive = 2;
            int negative = -3;
            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine(positive + ", ");
                Console.Write(negative);
                if (i == 499)
                {
                    Console.WriteLine(".");
                }
                else
                    Console.WriteLine(", ");
                positive = positive + 2;
                negative = negative - 2;
            }
        }
    }
}
