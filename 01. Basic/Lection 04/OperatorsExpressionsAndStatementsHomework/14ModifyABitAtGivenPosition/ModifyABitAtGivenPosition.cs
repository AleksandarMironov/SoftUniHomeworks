using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14ModifyABitAtGivenPosition
{
    class ModifyABitAtGivenPosition
    {
        static void Main()
        {
            Console.WriteLine("Enter num:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enpet position p:");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter bit value:");
            int v;
            do
            {
                v = int.Parse(Console.ReadLine());
                if (v != 0 && v != 1)
                    Console.WriteLine("Enter correct value! (0/1)");
            }
            while (v < 0 && v > 1);
            p = Math.Abs(p);
            int mask = 1;
            mask = mask << p;
            if ((mask & n) == 0)
            {
                if (v==1)
                {
                    n = mask ^ n;
                } 
            }
            else
                if (v==0)
                {
                    n = n^mask;
                }

            Console.WriteLine(n);

        }
    }
}
