using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            Console.WriteLine("Enter x and y coordinate:");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool check = (x*x+y*y<=2*2);
            Console.WriteLine(check);
        }
    }
}
