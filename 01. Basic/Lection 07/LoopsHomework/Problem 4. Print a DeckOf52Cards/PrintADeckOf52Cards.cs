﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04PrintADeckOf52Cards
{
    class PrintADeckOf52Cards
    {
        static void Main()
        {
            for (int i =0; i<13; i++)
            {
                for (int j = 0; j<4; j++)
                {
                    switch (i)
                    {
                        case 0: Console.Write("2"); break;
                        case 1: Console.Write("3"); break;
                        case 2: Console.Write("4"); break;
                        case 3: Console.Write("5"); break;
                        case 4: Console.Write("6"); break;
                        case 5: Console.Write("7"); break;
                        case 6: Console.Write("8"); break;
                        case 7: Console.Write("9"); break;
                        case 8: Console.Write("10"); break;
                        case 9: Console.Write("J"); break;
                        case 10: Console.Write("Q"); break;
                        case 11: Console.Write("K"); break;
                        case 12: Console.Write("A"); break;

                    }
                    switch (j)
                    {
                        case 0: Console.Write("♣ "); break;
                        case 1: Console.Write("♦ "); break;
                        case 2: Console.Write("♥ "); break;
                        case 3: Console.Write("♠ "); break;

                    }
                }
                Console.WriteLine("\n\r");
            }
        }
    }
}
