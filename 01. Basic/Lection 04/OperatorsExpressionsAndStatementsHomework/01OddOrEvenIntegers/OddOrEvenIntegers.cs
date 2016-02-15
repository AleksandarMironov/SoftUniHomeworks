using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main()
        {
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            bool check = (num % 2 != 0);
            if (check)
            {
                Console.WriteLine("The number is odd");
            }
            else
            {
                Console.WriteLine("The number is even"); 
            }
        }
    }
}
