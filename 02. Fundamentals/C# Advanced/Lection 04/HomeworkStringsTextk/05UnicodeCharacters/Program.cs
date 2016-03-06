using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05UnicodeCharacters
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char[] inputToArrey = input.ToCharArray();
            for (int i = 0; i < inputToArrey.Length; i++)
            {
                int temp = (int) inputToArrey[i];
                string tempInHex = temp.ToString("X");
                Console.Write("\\u00{0}", tempInHex );
            }
            Console.WriteLine();
         
        }
    }
}
