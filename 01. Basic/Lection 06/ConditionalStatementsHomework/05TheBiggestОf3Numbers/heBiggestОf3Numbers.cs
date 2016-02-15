using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05TheBiggestОf3Numbers
{
    class heBiggestОf3Numbers
    {
        static void Main()
        {
            Console.WriteLine("Enter numbers:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a>b)
            {
                b = a;
            }
            if (b>c)
            {
                c = b;
            }
            Console.WriteLine("biggest num is:" + c);
        }
    }
}
