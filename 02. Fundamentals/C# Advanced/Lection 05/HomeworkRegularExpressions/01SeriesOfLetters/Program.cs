using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01SeriesOfLetters
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();
            for (int i = 'a'; i <= 'z'; i++)     //a-z in ASCII are from 97 to 127, it can be coded: (int i = 97; i <= 127; i++) 
            {
                string regexPattern = ((char) i).ToString() + "+";
                Regex regex = new Regex(regexPattern);
                Match match = regex.Match(input);

                while (match != Match.Empty)
                {
                    input = input.Replace(match.Value, ((char)i).ToString());
                    match = match.NextMatch();
                }
            }
            Console.WriteLine(input);
        }
    }
}
