using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06PerimeterAndAreaOfPolygon
{
    class Polygon
    {
        List<Point> poly;
        int m;

        public Polygon(List<Point> polygon)
        {

            this.poly = polygon;
            poly.Add(polygon[0]);
            m = poly.Count();

        }

        public double GetPerimeter()
        {
            double perimeter = 0;
            for (int i = 0; i < m - 1; i++)
            {
                Point p1 = poly[i];
                Point p2 = poly[i + 1];
                perimeter += p1.Distance(p2);
            }
            return perimeter;
        }

        public double GetArea()
        {
            double left = 0;
            double right = 0;
            for (int i = 0; i < m - 1; i++)
            {
                Point p1 = poly[i];
                Point p2 = poly[i + 1];
                left += p1.x * p2.y;
                right += p2.x * p1.y;
            }
            return Math.Abs(left - right) / 2;
        }
    }
}
