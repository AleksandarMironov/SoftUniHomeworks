using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Rectangles
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the width of the rectangle:");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of the rectangle:");
            double height = double.Parse(Console.ReadLine());
            Console.Write("The perimeter is: ");
            Console.WriteLine(2*(width+height));
            Console.Write("The area is: ");
            Console.WriteLine(width*height);
        }
    }
}
