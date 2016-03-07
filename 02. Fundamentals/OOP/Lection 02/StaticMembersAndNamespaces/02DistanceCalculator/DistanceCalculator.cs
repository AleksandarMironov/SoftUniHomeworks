using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02DistanceCalculator
{
    static class DistanceCalculator
    {

        static public double CalculateDistanceBetwen2PointsIn3D(Point3D a, Point3D b)
        {
            return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y) + (a.Z - b.Z) * (a.Z - b.Z));
        }

    }
}
