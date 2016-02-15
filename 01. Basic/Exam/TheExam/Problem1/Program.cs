using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            r = r / 100 * 3.5;
            d = d * 1.5;
            e = e * 1.95;
            b = b / 2;
            if (r<d && r<e && r<b && r<m)
            {
                Console.WriteLine("{0:0.00}", r);
            }
            if (d < r && d < e && d < b && d < m)
            {
                Console.WriteLine("{0:0.00}", d);
            }
            if (e < d && e < r && e < b && e < m)
            {
                Console.WriteLine("{0:0.00}", e);
            }
            if (b < d && b < e && b < r && b < m)
            {
                Console.WriteLine("{0:0.00}", b);
            }
            if (m < d && m < e && m < b && m < r)
            {
                Console.WriteLine("{0:0.00}", m);
            }

        }
    }
}
