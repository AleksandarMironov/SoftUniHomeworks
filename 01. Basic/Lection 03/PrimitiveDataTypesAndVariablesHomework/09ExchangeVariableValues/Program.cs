using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09ExchangeVariableValues
{
    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("a={0}\nb={1}", a, b);
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("a={0}\nb={1}", a, b);

        }
    }
}
