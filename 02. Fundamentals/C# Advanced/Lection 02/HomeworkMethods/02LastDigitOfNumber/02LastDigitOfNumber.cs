using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02LastDigitOfNumber
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetLastDigitAsWord(number));

        }
        static string GetLastDigitAsWord (int num)
        {
            string output = "";
            int check = num % 10;
            switch (check)
            {
                case 1: output = "one"; break;
                case 2: output = "two"; break;
                case 3: output = "three"; break;
                case 4: output = "four"; break;
                case 5: output = "five"; break;
                case 6: output = "six"; break;
                case 7: output = "seven"; break;
                case 8: output = "eight"; break;
                case 9: output = "nine"; break;
                case 0: output = "zero"; break;
            }
            return output;
        }
    }
}
