using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10PointInsideACircleOutsideOfARectangle
{
    class PointInsideACircleOutsideOfARectangle
    {
        static void Main()
        {
            Console.WriteLine("Enter x and y coordinate:");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool checkK = (((x-1) * (x-1) + (y-1) * (y-1) <= 1.5 * 1.5));
            bool checkR = ((x > 5.0) || (x < -1.0)) || ((y > 1.0) || (y <-1.0));
            if (checkK && checkR)
            {
                Console.WriteLine("Yes");
            }
            else
                Console.WriteLine("No");
        }
    }
}
