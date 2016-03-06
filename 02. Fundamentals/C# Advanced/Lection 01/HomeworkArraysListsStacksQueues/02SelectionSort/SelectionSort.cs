using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputmass = input.Split(' ');
            double[] mass = new double[inputmass.Length];
            for (int i = 0; i < inputmass.Length; i++)
            {
                mass[i] = double.Parse(inputmass[i]);
            }
            double[] sortedMass = new double[mass.Length];
            for (int i = 0; i<mass.Length; i++)
            {
                double temp = new double();
                for (int i1 = i; i1<mass.Length; i1++)
                {
                    temp = double.MaxValue;
                    if (mass[i1] < temp)
                    {
                        temp = mass[i1];
                    }
                }
                sortedMass[i] = temp;
            }
            Console.WriteLine(string.Join(", ", sortedMass));

        }
    }
}
