using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03VariableInHexadecimalFormat
{
    class VarInHex
    {
        static void Main()
        {
            int myInt = 254;
            string myHex = myInt.ToString("X"); 
            int myNewInt = Convert.ToInt32(myHex, 16);
            Console.WriteLine("Number {0} in hex is 0x{1}, and 0x{1} in decimal is {2}", myInt, myHex, myNewInt);

        }
    }
}
