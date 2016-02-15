using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main()
        {
            Console.WriteLine("Enter num:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enpet position p:");
            int p = int.Parse(Console.ReadLine());
            p = Math.Abs(p);
            int mask = 1;
            if ((mask << p & n) == 0)
            {
                Console.WriteLine("0");
            }
            else
                Console.WriteLine("1");
        }
    }
}
