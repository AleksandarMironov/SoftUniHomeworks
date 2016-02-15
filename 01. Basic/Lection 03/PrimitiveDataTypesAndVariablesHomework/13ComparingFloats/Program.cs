using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13ComparingFloats
{
    class Program
    {
        static void Main()
        {
            double firNum = double.Parse(Console.ReadLine());
            double secNum = double.Parse(Console.ReadLine());
            double dif = firNum - secNum;
            double counst = 0.000001;
            bool check = (Math.Abs(dif)<counst);
            Console.WriteLine(check);
        }
    }
}
