using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Palindromes
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputWords = input.Split(new[] {" ", ",", ".", "!", "?", "-", "_", ":", ";", "\""},
                StringSplitOptions.RemoveEmptyEntries);
            List<string> list = new List<string>();
            for (int i = 0; i < inputWords.Length; i++)
            {
                if (IsPalindrome(inputWords[i]))
                {
                    list.Add(inputWords[i]);
                }
            }
            list.Sort();
            if (list.Count == 0)
            {
                Console.WriteLine("There is no polindromes!");
            }
            else
            {
                Console.WriteLine(string.Join(", ", list.ToArray()));               
            }


        }

        public static bool IsPalindrome(string word)
        {
            bool answer = true;
            int i = 0;
            int j = word.Length - 1;

            while (i < j)
            {
                if (word[i] != word[j])
                {
                    answer = false;
                }
                i++;
                j--;
            }

            return answer;
        }
    }
}
