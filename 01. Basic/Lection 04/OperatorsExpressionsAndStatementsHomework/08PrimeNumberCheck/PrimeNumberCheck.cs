using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.WriteLine("It it prime? Enter num:");
            int num = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i=2; i<num; i++)
            { 
                if (num%i==0)
                {
                    counter++;
                }
            }
            bool check = (counter == 0 && num!=1);
            Console.WriteLine(check);
            
        }
    }
}
