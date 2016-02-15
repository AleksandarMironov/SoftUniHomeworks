using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09PlayWithIntDoubleAndString
{
    class PlayWithIntDoubleAndString
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type: \n\r1 --> int \n\r2 --> double \n\r3 --> string");
            int type = int.Parse(Console.ReadLine());
            switch (type)
            {
                case 1:
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine(a+1);
                    break;
                case 2:
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine(b+1);
                    break;
                case 3:
                    string c = Console.ReadLine();
                    Console.WriteLine(c+'*');
                    break;
            }
        }
    }
}
