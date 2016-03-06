using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01BiggerNumber
{
    class Program
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(firstNum, secondNum ));
        }

        static int GetMax(int a, int b)
        {
            int max = 0;
            if (a>=b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            return max;
        }
    }
}
