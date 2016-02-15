using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11RandomNumbersInGivenRange
{
    class RandomNumbersInGivenRange
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            for (int i = 0; i<n; i++)
            {
                int num = rnd.Next(min, max);
                Console.WriteLine(num + " ");
            }

        }
    }
}
