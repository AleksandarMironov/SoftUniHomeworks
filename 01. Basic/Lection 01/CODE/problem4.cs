using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Problem4
    {
        static void Main(string[] args)
        {
           
            double stranac, stranaa, sb;
            System.Console.WriteLine ("Vavedete strana a");
            stranaa = double.Parse(Console.ReadLine());
            System.Console.WriteLine ("Vavedete strana b");
            sb = double.Parse(Console.ReadLine());
            stranac = Math.Sqrt (stranaa * stranaa + sb * sb);
            System.Console.WriteLine ("hipotenuzata =");
            System.Console.WriteLine (stranac);
        }
    }
}
