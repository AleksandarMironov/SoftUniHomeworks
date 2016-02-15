using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07QuotesInStrings
{
    class Program
    {
        static void Main()
        {
            string firstway = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(firstway);
            string secondway = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(secondway);
        }
    }
}
