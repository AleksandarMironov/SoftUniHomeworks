using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03LargerThanNeighbours
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter integers for arrey, separated by \" \":");
            string input = Console.ReadLine();
            double[] mass = input.Trim().Split().Select(double.Parse).ToArray();
            for (int i=0; i<mass.Length; i++)
            {
                Console.WriteLine(IsLargerThanNeighbours(mass, i));
            }

        }

        static bool IsLargerThanNeighbours (double [] mass, int positionOfElement)
        {
            bool output = false;
            if (positionOfElement > 0 && positionOfElement < mass.Length-1 && mass[positionOfElement] > mass[positionOfElement - 1] && 
                mass[positionOfElement] > mass[positionOfElement + 1])
            {
                output = true;
            }
            return output;
        }
    }
}
