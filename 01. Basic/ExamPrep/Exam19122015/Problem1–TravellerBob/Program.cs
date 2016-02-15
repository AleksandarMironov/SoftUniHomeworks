using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1_TravellerBob
{
    class Program
    {
        static void Main()
        {
            string leap = Console.ReadLine();
            int c = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            double normal = (12 - c - f) * 12 * 3 / 5.0;
            double answer = (c * 12) + (f * 4) + normal;   
            if (leap == "leap")
            {
                answer = answer * 1.05;
            }       
            Console.WriteLine(Math.Floor(answer));

        }
    }
}
