using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double[] mass = new double[n];
            double sum = 0;
            for (int i=0; i<n; i++)
            {
                mass[i] = double.Parse(Console.ReadLine());
                sum = sum + mass[i];
            }
            Console.WriteLine(sum);
        }
    }
}
