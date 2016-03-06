using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace _06XRemoval
{
    class Program
    {
        static void Main()
        {
            List <string> input = new List<string>();
            string tempInput = Console.ReadLine();
            int maxWordLenght = int.MinValue;
            while (tempInput != "END")
            {
                input.Add(tempInput);
                if (maxWordLenght < tempInput.Length)
                {
                    maxWordLenght = tempInput.Length;
                }
                tempInput = Console.ReadLine();
            }
            char [][] charMass = new char[input.Count][];
            char[][] charMassOutput = new char[input.Count][];            
            for (int i = 0; i < input.Count; i++)
            {
                charMass[i] = input[i].PadRight(maxWordLenght, ' ').ToLower().ToCharArray();
                charMassOutput[i] = input[i].PadRight(maxWordLenght, ' ').ToCharArray();
            }
            for (int i = 1; i < input.Count-1; i++)
            {
                for (int j = 1; j < maxWordLenght-1; j++)
                {
                    if (charMass[i][j] == charMass[i - 1][j - 1] && charMass[i][j] == charMass[i - 1][j + 1] &&
                        charMass[i][j] == charMass[i + 1][j - 1] && charMass[i][j] == charMass[i + 1][j + 1])
                    {
                        charMassOutput[i][j] = '\0';
                        charMassOutput[i-1][j-1] = '\0';
                        charMassOutput[i + 1][j - 1] = '\0';
                        charMassOutput[i - 1][j + 1] = '\0';
                        charMassOutput[i + 1][j + 1] = '\0';
                    }
                }
            }
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < maxWordLenght; j++)
                {
                    if (charMassOutput[i][j]!= '\0')
                    {
                        Console.Write(charMassOutput[i][j]);                        
                    }  
                }
                Console.WriteLine();
            }

        }
    }
}
