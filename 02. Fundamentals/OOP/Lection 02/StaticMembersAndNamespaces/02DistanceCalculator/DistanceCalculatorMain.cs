using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02DistanceCalculator
{
    class DistanceCalculatorMain
    {
        static void Main()
        {
            Point3D a = Point3D.StartingPoint();
            Point3D b = new Point3D(1,2,3.1);
            double answer = DistanceCalculator.CalculateDistanceBetwen2PointsIn3D(a, b);
            Console.WriteLine("Distance from a to b = " + answer);
        }
    }
}
