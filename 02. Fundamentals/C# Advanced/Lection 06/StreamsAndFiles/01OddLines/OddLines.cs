using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01OddLines
{
    class OddLines
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\OddLines.cs");
            string str;
            int line = 0;
            using (reader)
            {
                do
                {
                    str = reader.ReadLine();
                    line++;
                    str = reader.ReadLine();
                    Console.WriteLine("Line {0, 2}: {1}", line, str);
                    line++;
                } while (str != null);
            }
        }
    }
}