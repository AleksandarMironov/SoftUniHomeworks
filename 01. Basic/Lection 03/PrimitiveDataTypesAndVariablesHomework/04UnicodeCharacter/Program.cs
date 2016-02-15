using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04UnicodeCharacter
{
    class Program
    {
        static void Main()
        {
            char a = '*';
            Console.WriteLine((int)a); // * is whit 42 code
            char b = '\u002A';    //42d is 2A in hex
            Console.WriteLine(b);
        }
    }
}
