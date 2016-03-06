﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace _02ReplaceATag
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"<a.*href=((?:.|\n)*?(?=>))>((?:.|\n)*?(?=<))<\/a>";
            string replace = @"[URL href=$1]$2[/URL]";
            string replaced = Regex.Replace(input, pattern, replace);
            Console.WriteLine(replaced); 
        }
    }
}
