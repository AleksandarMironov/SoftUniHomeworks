using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("Enter a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c:");
            double c = double.Parse(Console.ReadLine());
            if ((b*b - 4*a*c) < 0)
            {
                Console.WriteLine("no real roots");
            }
            if (b*b - 4*a*c == 0)
            {
                Console.WriteLine("X1=X2={0}", -1*b/(2*a));
            }
            if (b*b -4*a*c >0)
            {
                Console.WriteLine("X1= {0} \t X2= {1}", (-1*b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a), (-1*b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
            }
        }
    }
}
