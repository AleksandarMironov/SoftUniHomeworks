using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Sort3NumbersWithNestedIfs
{
    class Sort3NumbersWithNestedIfs
    {
        static void Main()
        {
            Console.WriteLine("Enter numbers:");
            double a = double.Parse(Console.ReadLine());      /// 321 231 132 
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double temp;
            if (a < b)
            {
                temp = b;
                b = a;
                a = temp;
                if (a<c)
                {
                    temp = c;
                    c = a;
                    a = temp;
                }
                if (b < c)
                {
                    temp = c;
                    c = b;
                    b = temp;
                }
            }
            if (a < c)
            {
                temp = c;
                c = a;
                a = temp;
                if (b < c)
                {
                    temp = c;
                    c = b;
                    b = temp;
                }
            }
            Console.WriteLine("{0}, {1}, {2}", a, b, c);
        }
    }
}
