using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            Console.WriteLine("Enter side a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height h:");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Area of the trapezoid is: " + (a+b)/2*h);
        }
    }
}
