using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SumOf3Numbers
{
    class SumOf3Numbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("a+b+c={0}", a+b+c);
        }
    }
}
