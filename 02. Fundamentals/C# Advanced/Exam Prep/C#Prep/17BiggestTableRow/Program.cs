using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _17BiggestTableRow
{
    class Program
    {
        static void Main()
        {
            
            string input = Console.ReadLine();
            int counter = 1;
            int rollWhitBiggestSum = 0;
            string output = "no data";
            double biggestSum = Double.MinValue;
            string pattern = @"(?<=>)(-*[0-9]+\.*[0-9]*)"; 
            Regex nums = new Regex(pattern);
            while (input != "</table>")
            {
                if (Regex.Matches(input, pattern).Count > 0)
                {
                    var mathes = Regex.Matches(input, pattern);
                    double tempSum = 0;
                    List<string> tempList = (from object match in mathes select match.ToString()).ToList();

                    for (int i = 0; i < tempList.Count(); i++)
                    {
                        tempSum = tempSum + double.Parse(tempList[i]);
                    }
                    if (tempSum > biggestSum)
                    {
                        biggestSum = tempSum;
                        output = tempSum + " = " + string.Join(" + ", tempList);
                    }
                } 

                input = Console.ReadLine();
                counter ++;
            }
            Console.WriteLine(output);
        }
    }
}
 