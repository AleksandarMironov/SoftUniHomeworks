using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05PointClass
{
    class Point
    {
        public double x;
        public double y;

        public Point (double a, double b)
        {
            x = a;
            y = b;
        }
    }
    
    class PointClass
    {
        static void Main()
        {
            Point a = new Point(20, 30);
            Point b = new Point(0, 100);
        }
    }
}
