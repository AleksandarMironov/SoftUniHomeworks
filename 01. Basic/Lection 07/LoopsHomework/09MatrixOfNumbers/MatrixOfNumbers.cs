using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());

            }
            while (n > 20 || n < 1);
            for (int i = 0; i<n; i++)
            {
                for (int z = 1; z<=n; z++)
                {
                    Console.Write("{0} ", z+i);
                }
                Console.WriteLine("\n\r");
            }
        }
    }
}
