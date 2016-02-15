using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter num:");
            int num = int.Parse(Console.ReadLine());
            int a = num / 1000 % 10;
            int b = num / 100 % 10;
            int c = num / 10 % 10;
            int d = num % 10;
            Console.WriteLine("Sum of digits: " + (a+b+c+d));
            Console.WriteLine("Reversed: {3}{2}{1}{0}	\nLast digit in front: {3}{0}{1}{2}	\nSecond and third digits exchanged: {0}{2}{1}{3}",a,b,c,d);
        }
    }
}
