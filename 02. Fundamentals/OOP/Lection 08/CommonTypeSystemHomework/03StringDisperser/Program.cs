using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03StringDisperser
{
    class Program
    {
        static void Main()
        {
            StringDisperser stringDisperser = new StringDisperser("gosho", "pesho", "tanio");

            StringDisperser stringDisperser2 = new StringDisperser("joro", "moro", "pepi");


            var stringDisperser3 = stringDisperser.Clone() as StringDisperser;
            stringDisperser3.Strings.Add("Mlechko");

            Console.WriteLine();
            var stringDespersers = new List<StringDisperser> { stringDisperser, stringDisperser2, stringDisperser3 };
            stringDespersers.Sort();
            Console.WriteLine(string.Join("\n", stringDespersers));

            Console.WriteLine();
            foreach (var ch in stringDisperser)
            {
                Console.Write(ch + " ");
            }
            Console.WriteLine(  );
        }
    }
}
