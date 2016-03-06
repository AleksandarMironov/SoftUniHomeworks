using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04FirstLargerThanNeighbours
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter integers for arrey, separated by \" \":");
            string input = Console.ReadLine();
            double[] mass = input.Trim().Split().Select(double.Parse).ToArray();
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(mass));

        }
        static int GetIndexOfFirstElementLargerThanNeighbours(double[] mass)
        {
            int output = -1;
            for (int i = 0; i < mass.Length; i++)
            {

                if (i > 0 && i < mass.Length - 1 && mass[i] > mass[i - 1] && mass[i] > mass[i + 1])
                {
                    output = i;
                    break;
                }
            }
            return output;
        }
    }
}
