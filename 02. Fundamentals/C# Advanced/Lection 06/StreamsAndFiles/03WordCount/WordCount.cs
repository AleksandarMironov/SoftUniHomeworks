using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03WordCount
{
    class WordCount
    {
        static void Main()
        {
            List<string> wordsList = new List<string>();
            using (StreamReader wordsListReader = new StreamReader("../../words.txt"))
            {
                string line;
                while ((line = wordsListReader.ReadLine()) != null)
                {
                    wordsList.Add(line);
                }
            }
            StringBuilder textBuilder = new StringBuilder();
            using (StreamReader textReader = new StreamReader("../../text.txt"))
            {
                string line;
                while ((line = textReader.ReadLine()) != null)
                {
                    textBuilder.Append(line);
                }
            }
            string text = textBuilder.ToString();
            var wordsDict = new Dictionary<string, int>();
            foreach (string word in wordsList)
            {
                Regex wordRegEx = new Regex(@"\b" + word + @"\b", RegexOptions.IgnoreCase);
                MatchCollection matches = wordRegEx.Matches(text);
                if (matches.Count > 0)
                {
                    wordsDict[word] = matches.Count;
                }
            }
            File.Create("../../result.txt").Close();
            wordsDict = wordsDict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            StreamWriter writer = new StreamWriter(@"..\..\result.txt");
            foreach (KeyValuePair<string, int> pair in wordsDict)
            {

                writer.WriteLine("{0} - {1}", pair.Key, pair.Value);
                
            }
            writer.Close();
            
            Console.WriteLine(File.ReadAllText("../../result.txt"));
        }
    }
}
