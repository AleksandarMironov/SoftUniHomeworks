using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            Console.WriteLine("Enter numbers:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            int temp = 1;
            if (a > 0)
                temp = temp * 1;
            else if (a < 0)
                temp = temp * -1;
            if (b > 0)
                temp = temp * 1;
            else if (b < 0)
                temp = temp * -1;
            if (c > 0)
                temp = temp * 1;
            else if (c < 0)
                temp = temp * -1;
            if (a == 0 || b == 0 || c == 0)
                temp = temp * 0;
            if (temp == 0)
                Console.WriteLine("0");
            if (temp > 0)
                Console.WriteLine("+");
            if (temp < 0)
                Console.WriteLine("-");


        }
    }
}
