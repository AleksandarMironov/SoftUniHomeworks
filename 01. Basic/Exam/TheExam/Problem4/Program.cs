using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string [] mass = input.Split('\\');
            char[] left = mass[0].ToArray();
            char[] right = mass[1].ToArray();
            List<char> output = new List<char>();
            switch (mass[2])
            {
                case "join":
                    {
                        for (int i = 0; i < left.Length; i++ )
                        {
                            for (int i2 = 0; i2 < right.Length; i2++ )
                            {
                                if (left[i] == right[i2])
                                {
                                    output.Add(left[i]);
                                }
                            }
                        }
                        break;

                    }
                case "right exclude":
                    {
                        output = left.Except(right).ToList();
                        break;
                    }
                case "left exclude":
                    {
                        output = right.Except(left).ToList();

                        break;
                    }
            }
            output.Sort();
            foreach (char letter in output)
            {
                Console.Write(letter);
            }
            Console.WriteLine();
            
        }
    }
}
