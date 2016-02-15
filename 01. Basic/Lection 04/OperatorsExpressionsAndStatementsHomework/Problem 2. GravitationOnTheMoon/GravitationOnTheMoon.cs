using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main()
        {
            Console.WriteLine("Enter your weight:");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Your weight on the Moon is:");
            Console.WriteLine(0.17*weight);
        }
    }
}
