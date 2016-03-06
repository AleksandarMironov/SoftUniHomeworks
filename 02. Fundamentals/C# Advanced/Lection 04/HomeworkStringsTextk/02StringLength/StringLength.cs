using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _02StringLength
{
    class StringLength
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string output = input.PadRight(20, '*').Substring(0, 20);
            Console.WriteLine(output);
        }
    }
}
