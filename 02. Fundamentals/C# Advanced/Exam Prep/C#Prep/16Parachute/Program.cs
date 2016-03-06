using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Parachute
{
    class Program
    {
        static void Main()
        {
            List<string> input = new List<string>();
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
            char[][] charMass = new char[input.Count][];
            for (int i = 0; i < input.Count; i++)
            {
                charMass[i] = input[i].ToCharArray();
            }
            int position = 0;
            int roll = 0;
            int movment = 0;

            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < charMass[0].Length; j++)
                {
                    if (charMass[i][j] == 'o')
                    {
                        roll = i;
                        position = j;
                    }
                }
            }

            for (int i = roll; i < input.Count; i++)
            {
                for (int j = 0; j < charMass[0].Length; j++)
                {
                    if (i != roll)
                    {
                        if (charMass[i][j] == '>')
                        {
                            position++;
                        }
                        else if (charMass[i][j] == '<')
                        {
                            position--;
                        }
                    }
                }
                if (charMass[i][position] == '/' || charMass[i][position] == '\\' || charMass[i][position] == '|')
                {
                    Console.WriteLine("Got smacked on the rock like a dog!");
                    Console.WriteLine(i + " " + position);
                    break;
                }
                if (charMass[i][position] == '_')
                {
                    Console.WriteLine("Landed on the ground like a boss!");
                    Console.WriteLine(i + " " + position);
                    break;
                }
                if (charMass[i][position] == '~')
                {
                    Console.WriteLine("Drowned in the water like a cat!");
                    Console.WriteLine(i + " " + position);
                    break;
                }
            }
        }
    }
}
