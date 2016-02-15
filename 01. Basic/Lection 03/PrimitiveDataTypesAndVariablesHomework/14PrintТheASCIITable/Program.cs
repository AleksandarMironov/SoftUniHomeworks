using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14PrintТheASCIITable
{
    class Program
    {
        static void Main()
        {
            //// Console.OutputEncoding = new UTF8Encoding();  /// Отново не се изписват всички символи.....
            Console.WriteLine("Dec  Hex   ASCII");
            for (int i = 0; i < 256; i++)
            {
                char simbol = (char)i;
                Console.WriteLine("{0} ---> {2} ---> {1}", i, simbol, i.ToString("X"));
            }
        }
    }
}
