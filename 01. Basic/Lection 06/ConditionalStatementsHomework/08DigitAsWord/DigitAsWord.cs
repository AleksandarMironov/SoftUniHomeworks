﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08DigitAsWord
{
    class DigitAsWord
    {
        static void Main()
        {
            Console.WriteLine("Enter digit (0-9):");
            int dig = int.Parse(Console.ReadLine());
            switch (dig)
            {
                case 0: Console.WriteLine("Zero"); break;
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                case 4: Console.WriteLine("Four"); break;
                case 5: Console.WriteLine("Five"); break;
                case 6: Console.WriteLine("Six"); break;
                case 7: Console.WriteLine("Eight"); break;
                case 8: Console.WriteLine("Zero"); break;
                case 9: Console.WriteLine("Nine"); break;
                default: Console.WriteLine("not a digit"); break;
            }
        }
    }
}
