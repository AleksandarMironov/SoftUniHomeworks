using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10LongestWordInAText
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] { ' ', ',', ':', ';', '.', '-' }, StringSplitOptions.RemoveEmptyEntries);
            int longestWordIndex = 0;
            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length > words[longestWordIndex].Length)
                {
                    longestWordIndex = i;
                }
            }

            Console.WriteLine(words[longestWordIndex]);
        }
    }
}
