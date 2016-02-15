using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintASequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int positive = 2;
            int negative = -3;
            for (int i = 0; i < 5; i++)
            {
                Console.Write(positive + ", ");
                Console.Write(negative);
                if (i == 4)  
                {
                    Console.WriteLine(".");
                }
                else
                    Console.Write(", ");
                positive = positive + 2;
                negative = negative - 2;
            }
        }
    }
}
