using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a>b)
            {
                int temp;
                temp = a;
                a = b;
                b = temp;
            }
            Console.WriteLine(a + " " + b);

        }
    }
}
