using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02StringMatrixRotation
{
    class Program
    {
        static void Main()
        {
            string rotate = Console.ReadLine();
            string pattern = @"\d+";
            Regex regex = new Regex(pattern);
            string degreace = regex.Match(rotate).ToString();
            int rotateDec = int.Parse(degreace);
            List<string> listOfWords = new List<string>();
            string input = Console.ReadLine();
            int lettersInWord = Int32.MinValue;
            int enteredWords = 0;
            while (input != "END")
            {
                enteredWords++;
                if (lettersInWord < input.Length)
                {
                    lettersInWord = input.Length;
                }
                listOfWords.Add(input);
                input = Console.ReadLine();
            }
            string[] wordMass = listOfWords.ToArray();
            for (int i = 0; i < enteredWords; i++)
            {
                wordMass[i] = wordMass[i].PadRight(lettersInWord, ' ');
            }
            int rotations = rotateDec % 360;   
            if (rotations == 0)
            {
                foreach (string word in wordMass)
                {
                    Console.WriteLine(word); 
                }
            }
            if (rotations == 90)
            {
                for (int i = 0; i < lettersInWord; i++)
                {
                    for (int j = enteredWords-1; j >= 0; j--)
                    {
                        Console.Write(wordMass[j][i]);
                    }
                    Console.WriteLine();
                }

            }
            if (rotations == 180)
            {
                for (int i = wordMass.Count()-1; i >= 0; i--)
                {
                    for (int j = lettersInWord - 1; j >= 0; j--)
                    {
                        Console.Write(wordMass[i][j]);
                    }
                    Console.WriteLine();
                }

            }
            if (rotations == 270)
            {
                for (int i = lettersInWord - 1; i >= 0; i--)
                {
                    for (int j = 0; j < enteredWords; j++)
                    {
                        Console.Write(wordMass[j][i]);
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
