using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02LineNumbers
{
    class LineNumbers
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\LineNumbers.cs");
            StreamWriter writer =  new StreamWriter(@"..\..\LineNumbersWithNumbers.txt");
            string str;
            int lineNumber = 1;
            using (reader)
            using (writer)
            {
                do
                {
                    str = reader.ReadLine();
                    writer.WriteLine("{0} {1}", lineNumber, str);
                    lineNumber++;
                } while (str != null);
            }
            Console.WriteLine("Task complete:\n");
            string readedFile = File.ReadAllText(@"..\..\LineNumbersWithNumbers.txt");
            Console.WriteLine(readedFile);
        }
    }
}
