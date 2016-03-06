using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main()
        {

            Console.WriteLine("Enter text:");
            string inputText = Console.ReadLine().ToLower();
            Console.WriteLine("Enter string to search:");
            string search = Console.ReadLine().ToLower();
            int index = 0;
            int counter = 0;
            while (index>-1)
            {
                if (index == 0)
                {
                    index = inputText.IndexOf(search);
                    if (index > -1)
                    {
                        counter++;
                    }
                }
                index = inputText.IndexOf(search, index+1);
                if (index > -1)
                {
                    counter++;
                } 
            }
            Console.WriteLine(counter);
     
        }
    }
}
