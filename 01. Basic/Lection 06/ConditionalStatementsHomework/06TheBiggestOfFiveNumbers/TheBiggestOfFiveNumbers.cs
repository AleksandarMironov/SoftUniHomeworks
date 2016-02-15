using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06TheBiggestOfFiveNumbers
{
    class TheBiggestOfFiveNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter numbers:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            if (a > b)
            {
                b = a;
            }
            if (b > c)
            {
                c = b;
            }
            if (c > d)
            {
                d = c;
            }
            if (d > e)
            {
                e = d;
            }
            Console.WriteLine("biggest num is:" + e);
        }
    }
}
