using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SortingNumbers
{
    class SortingNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            for (int i = 0; i<mass.Length; i++)
            {
                mass[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n\r");
            Array.Sort(mass);
            foreach (int num in mass)
            {
                Console.WriteLine(num);
            }
        }
    }
}
