using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            int a;
            do
            {
                a = int.Parse(Console.ReadLine());
                if (a < 0 || a > 500)
                {
                    Console.WriteLine("Enter value from 0 to 500");
                }
            }
            while (a < 0 || a > 500); 
            float b = 0.00F;
            b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine("|{0, -10}|{1}|{2,10:0.00}|{3,-10:0.000}|", Convert.ToString(a, 16), Convert.ToString(a, 2).PadLeft(10, '0'), b, c); 

        }
    }
}
