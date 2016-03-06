using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04TextFilter
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter ban words, separated by , or \" \":");
            string banWords = Console.ReadLine();
            string[] ban = banWords.Split(new[] {",", " "}, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();
            string [] textEditions = new string[ban.Length+1];
            textEditions[0] = text;
            for (int i = 0; i < ban.Length; i++)
            {
                textEditions[i + 1] = textEditions[i].Replace(ban[i], new string('*', ban[i].Length));
            }
            Console.WriteLine(textEditions[ban.Length]);
        }
    }
}
