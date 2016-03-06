using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04SentenceExtractor
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter keyword:");
            string word = Console.ReadLine();
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();
            string sentencePattern = @"\b[\w\s,`()'-]+[.!?]";
            MatchCollection matches = Regex.Matches(text, sentencePattern);
            foreach (var match in matches)
            {
                if (match.ToString().Split(' ').Contains(word))
                {
                    Console.WriteLine(match);
                }
            }
        }
    }
}
