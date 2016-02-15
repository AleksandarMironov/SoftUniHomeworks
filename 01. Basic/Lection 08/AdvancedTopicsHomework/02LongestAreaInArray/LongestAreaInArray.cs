using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02LongestAreaInArray

{
    class LongestAreaInArray
    {
         static void Main()
         {
        
            int n = int.Parse(Console.ReadLine());
            string lastString = "", longestSeqString = "";
            int longestSequence = 1, currentSequence = 0;
            string[] strings = new string[n];
            for (int i = 0; i < n; i++)
            {
                strings[i] = Console.ReadLine();
                if (lastString == strings[i])
                {
                    currentSequence++;
                    if (currentSequence > longestSequence)
                    {
                        longestSequence = currentSequence;
                        longestSeqString = strings[i];
                    }
                }
                else
                {
                    currentSequence = 1;
                }
                lastString = strings[i];
            }
 
            Console.WriteLine(longestSequence);
 
            for (int i = 1; i <= longestSequence; i++)
            {
                Console.WriteLine(longestSeqString);
            }
        }

    }
}
