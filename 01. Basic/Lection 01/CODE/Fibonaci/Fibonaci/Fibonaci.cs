using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonaci
{
    class Fibonaci
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Is it Finobaci? Enter number:");
            int fib = int.Parse(Console.ReadLine());
            int a=0;
            int b=1;
            int c;
            int position=2;
            if (fib == 0)
            {
                Console.WriteLine("It is Fibonaci. At position: 1");
            }
            if (fib == 1)
            {
                Console.WriteLine("It is Fibonaci. At position: 2/3");
            }
            if (fib > 1)
            {
                do
                {

                    c = a + b;
                    position++;
                    if (c == fib)
                    {
                        Console.WriteLine("It is Fibonaci. At position:");
                        Console.WriteLine(position);
                    }
                    if (c > fib)
                    {
                        Console.WriteLine("It is NOT Fibonaci.");
                    }
                    a = b;
                    b = c;
                }
                while (c < fib);
            }

        }
    }
}




