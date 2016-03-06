using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace important
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex emailRegex = new Regex(@"(?<![._\w+-])(?<user>\w+([-+.]\w+)*)@(?<host>\w+([-.]\w+)*\.\w+([-.]\w+)*)", RegexOptions.IgnoreCase);
 string pattern = @"<a\s+href=([^>]+)>([^<]+)</a>";
Regex regex = new Regex(pattern);
string replacement = "[URL href=$1]$2[/URL]";
string result = Regex.Replace(input, pattern, replacement);
        }
    }
}
