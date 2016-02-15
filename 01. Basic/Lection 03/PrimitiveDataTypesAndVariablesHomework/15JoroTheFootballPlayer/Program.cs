using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15JoroTheFootballPlayer
{
    class Program
    {
        static void Main()
        {
            char leap = char.Parse(Console.ReadLine());
            int p; ////holydays
            do
            {
                p = int.Parse(Console.ReadLine());
                if (p > 300 || p<0)
                {
                    Console.WriteLine("enter again");
                }
            }
            while (p > 300 || p<0);
            int h; ////hometown 
            do
            {
                h = int.Parse(Console.ReadLine());
                if (h > 52 || h<0)
                {
                    Console.WriteLine("enter again");
                }
            }
            while (h > 52 || h < 0);
            double answer = (p/2) + (52-h)*2/3 + h;
            if (leap == 't')
            {
                answer = answer + 3;
            }
            Console.WriteLine((int)answer);
        }
    }
}
