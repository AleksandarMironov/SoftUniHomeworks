using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04SequencesOfEqualStrings
{
    class SequencesOfEqualStrings
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<string> list = new List<string>(input.Split(' '));
            Console.Write(list.ElementAt(0) + " ");
            for (int i = 1; i < list.Count; i++) 
            {
                if (list.ElementAtOrDefault(i) != list.ElementAtOrDefault(i-1))
                {
                    Console.WriteLine();
                }
                Console.Write(list.ElementAtOrDefault(i) + " ");
            }
            Console.WriteLine();

        }
    }
}