using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_SpyHard
{
    class Program
    {
        static void Main()
        {
            int key = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int totalValue = 0;
            string convVal = "";
            for (int i =0; i<input.Length; i++ )
            {
                if (input [i] >= 'A' && input[i] <= 'Z')
                {
                    totalValue = input[i] - 64;
                } else if (input [i] >= 'a' && input[i] <= 'a')
                {
                    totalValue = input[i] - 96;
                }
                else
                {
                    totalValue += input[i];
                }
            }
            do
            {
                convVal = (totalValue % key) + convVal;
                totalValue /= key;
            }
            while (totalValue != 0);
            Console.WriteLine(key.ToString() + input.Length + convVal);

        }
    }
}
