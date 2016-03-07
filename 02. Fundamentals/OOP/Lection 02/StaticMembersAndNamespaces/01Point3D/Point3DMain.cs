using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Point3D
{
    class Point3DMain
    {
        private static void Main()
        {
            Point3D a = new Point3D(1, 2, 3);
            Console.WriteLine(a);
            Console.WriteLine(Point3D.StartingPoint());      
        }
    }
}
