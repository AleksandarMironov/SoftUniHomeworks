using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15BitsExchange
{
    class BitsExchange
    {
        static void Main()
        {
            Console.WriteLine("Enter numm:");
            uint n = uint.Parse(Console.ReadLine());
            uint mask = 7; ///00000....00000111
            uint bits345 = (n & (mask << 3))>>3;
            uint bits242526 = (n & (mask << 24))>>24;
            n = n & ~(mask << 3);
            n = n & ~(mask << 24);
            n = n | (bits345 << 24);
            n = n | (bits242526 << 3);
            Console.WriteLine(n);

        }
    }
}
