using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05ReverseNumber
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter num:");
            double num = double.Parse(Console.ReadLine());
            double reversed = GetReversedNumber(num);
            Console.WriteLine(reversed);
        }

        static double GetReversedNumber (double inputNum)
        {
            string numInString = inputNum.ToString().Trim('-');
            bool negative = inputNum < 0;
            string reversedNumInString = ReverseString(numInString);
            double output = double.Parse(reversedNumInString);
            return negative?  -output : output;
        }

        static string ReverseString(string srtVarable)
        {
            return new string(srtVarable.Reverse().ToArray());
        }
    }
}
