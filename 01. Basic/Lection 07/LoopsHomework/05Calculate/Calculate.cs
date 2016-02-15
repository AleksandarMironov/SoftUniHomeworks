using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Calculate
{
    class Calculate
    {                               
        static void Main()
        {
            Console.WriteLine("n=");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("x=");
            int x = int.Parse(Console.ReadLine());
            double answer = 0;
            for (int i = 0, numerator = 1; i<=n; i++, numerator = numerator * i)
            {
                answer = answer + (numerator / Math.Pow(x, i));
            } 
            Console.WriteLine("answer= {0:0.00000}", answer);
        }
    }
}
