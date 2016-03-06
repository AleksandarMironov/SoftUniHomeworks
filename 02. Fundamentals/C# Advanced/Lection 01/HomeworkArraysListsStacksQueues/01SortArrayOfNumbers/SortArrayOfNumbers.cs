using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SortArrayOfNumbers
{
    class SortArrayOfNumbers
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputmass = input.Split(' ');
            double [] mass = new double[inputmass.Length];
            for (int i = 0; i < inputmass.Length; i++ )
            {
                mass[i] = double.Parse(inputmass[i]);
            }
            for (int i = 0; i < mass.Length; i++)
            {
                for (int i1 = 0; i1 < mass.Length-1; i1++)
                {
                    if (mass[i1] > mass[i1 + 1])
                    {
                        double temp = mass[i1];
                        mass[i1] = mass[i1 + 1];
                        mass[i1 + 1] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", mass));

            


        }
    }
}