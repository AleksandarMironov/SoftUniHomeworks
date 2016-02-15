using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.WriteLine("Enter r of the chircle:");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Perimeter = {0:#.##}", 2*Math.PI*r);
            Console.WriteLine("Area = {0:#.##}", Math.PI * r * r);
        }
    }
}
