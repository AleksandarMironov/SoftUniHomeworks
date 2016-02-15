using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13CheckABitAtGivenPosition
{
    class CheckABitAtGivenPosition
    {
        static void Main()
        {
            Console.WriteLine("Enter num:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enpet position p:");
            int p = int.Parse(Console.ReadLine());
            p = Math.Abs(p);
            int mask = 1;
            bool check;
            if ((mask << p & n) == 0) 
                check = false;
            else
                check = true;
            Console.WriteLine(check);
        }
    }
}
