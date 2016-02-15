using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06PerimeterAndAreaOfPolygon
{

    public class PerimeterAndAreaOfPolygon
    {

        public static void Main()
        {
            Console.WriteLine("Write n = ");
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
                if (n<3)
                {
                    Console.WriteLine("You need at least 3 points for polygon!");
                }
            }
            while (n < 3);
            List<Point> listOfPoints = new List<Point>{};
            Console.WriteLine("Enter points:");
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] list = input.Split(' ');
                double x = double.Parse(list[0]);
                double y = double.Parse(list[1]);
                Point p = new Point(x, y);
                listOfPoints.Add(p);
            }
            Polygon polygon = new Polygon(listOfPoints);
            double perimeter = polygon.GetPerimeter();
            double area = polygon.GetArea();
            Console.WriteLine(" Area = {0:0.00} \n\r Perimeter = {1:0.00}.", area, perimeter);
        }
    }
}

