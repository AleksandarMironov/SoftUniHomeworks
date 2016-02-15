using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11BitwiseExtractBit3
{
    class BitwiseExtractBit3
    {
        static void Main()
        {
            Console.WriteLine("Enter num:");
            uint num = uint.Parse(Console.ReadLine());
            uint mask = 1;
            if ((mask << 3 & num) == 0)
            {
                Console.WriteLine("0");
            }
            else
                Console.WriteLine("1");

        }
    }
}
