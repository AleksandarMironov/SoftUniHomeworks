using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04NumberComparer
{
    class NumberComparer
    {
        static void Main()
        {
            Console.WriteLine("Enter a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Greater number is: {0}", Math.Max(a,b));

        }
    }
}
