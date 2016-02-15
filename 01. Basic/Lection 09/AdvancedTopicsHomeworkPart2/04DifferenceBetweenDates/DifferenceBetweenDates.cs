using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04DifferenceBetweenDates
{
    class DifferenceBetweenDates
    {
        static void Main()
        {
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            DateTime secondDate = DateTime.Parse(Console.ReadLine());
            TimeSpan t = secondDate - firstDate;
            int answer = t.Days;
            Console.WriteLine(answer);
    
        }
    }
}
