using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApplication2
{
    class problem3
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("vavedete chislo za faktoriel");
            int fac = int.Parse(Console.ReadLine());
            BigInteger f = fac;
            int a = 1;
            do
            {
                f = f * a;
                a++;
            }
            while (a < fac);
            System.Console.WriteLine(f);

        }
    }
}