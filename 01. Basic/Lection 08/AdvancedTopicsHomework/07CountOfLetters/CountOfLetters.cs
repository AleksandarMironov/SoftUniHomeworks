using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07CountOfLetters
{
    class CountOfLetters
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();
            int[] mass = new int[26];
            foreach (char character in input)
            {
                switch (character)
                {
                    case 'a': mass[0]++; break;
                    case 'b': mass[1]++; break;
                    case 'c': mass[2]++; break;
                    case 'd': mass[3]++; break;
                    case 'e': mass[4]++; break;
                    case 'f': mass[5]++; break;
                    case 'g': mass[6]++; break;
                    case 'h': mass[7]++; break;
                    case 'i': mass[8]++; break;
                    case 'j': mass[9]++; break;
                    case 'k': mass[10]++; break;
                    case 'l': mass[11]++; break;
                    case 'm': mass[12]++; break;
                    case 'n': mass[13]++; break;
                    case 'o': mass[14]++; break;
                    case 'p': mass[15]++; break;
                    case 'q': mass[16]++; break;
                    case 'r': mass[17]++; break;
                    case 's': mass[18]++; break;
                    case 't': mass[19]++; break;
                    case 'u': mass[20]++; break;
                    case 'v': mass[21]++; break;
                    case 'w': mass[22]++; break;
                    case 'x': mass[23]++; break;
                    case 'y': mass[24]++; break;
                    case 'z': mass[25]++; break;
                    default: break;
                }
            }
            for (int i = 0; i< mass.Length; i++)
            {
                if (mass[i]>0)
                {
                    Console.WriteLine("{0} -> {1}", (char)(i+97), mass[i]);
                }
            }
         
        }
    }
}
