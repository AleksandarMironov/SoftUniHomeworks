using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_Headphones
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            for (int i = 0; i<size; i++)
            {
                for (int z=0; z<(size-1)/2; z++)
                {
                    Console.Write("_");

                }
                Console.Write("*");
                if (i==0)
                {
                    for (int k = 0; k<size; k++)
                    {
                        Console.Write("*");
                    }
                }
                if (i != 0)
                {
                    for (int k1 = 0; k1 < size; k1++)
                    {
                        Console.Write("_");
                    }
                }
                Console.Write("*");
                for (int z1 = 0; z1 < (size - 1) / 2; z1++)
                {
                    Console.Write("_");

                }
                Console.WriteLine(" ");
            }
            for (int i1 = 0, count = 0; i1<size; i1++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string ('_', ((size -1)/2 - count)), new string ('*', 1+2*count),
            new string ('_',size-2*count ));
            if (i1<size/2 )
            {
                count ++;

            }
            else
            {
                count--;
            }
                
            }
        }
    }
}
