using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main()
        {
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            bool check = (num % 5  == 0 && num % 7 == 0);
            Console.WriteLine("The number {0} can be devided by 7 and 5 in the same time: {1}", num, check);
        }
    }
}
