using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchtheBits
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            //int step = int.Parse(Console.ReadLine());
            //int [] mass = new int [n];
            //for (int i=0; i<n; i++)
            //{
              //  mass[i] = int.Parse(Console.ReadLine());
            //}
            string test = Convert.ToString(n,2);
            Console.WriteLine(test);
            int testa = Convert.ToInt32(test, 2);
            Console.WriteLine(testa);
        }
    }
}
