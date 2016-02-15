using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06PerimeterAndAreaOfPolygon
{
    class Point
    {
        public double x;
        public double y;

        public Point(double X, double Y)
        {
            x = X;
            y = Y;
        }

        public double Distance(Point p2)
        {
            double x1 = this.x;
            double y1 = this.y;
            double x2 = p2.x;
            double y2 = p2.y;
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }
    }
}
