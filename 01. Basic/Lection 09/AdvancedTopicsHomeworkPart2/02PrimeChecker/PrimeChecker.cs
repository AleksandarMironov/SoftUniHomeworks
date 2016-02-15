using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PrimeChecker
{
    class PrimeChecker
    {
        static void Main()
        {
            int n = 0;
            string check = "";
            do
            {
                Console.WriteLine("Is it prime? Enter num: ");
                n = int.Parse(Console.ReadLine());
                bool isPrime = IsPrime(n);
                Console.WriteLine(isPrime);
                Console.WriteLine("Do you want to enter next num? (Y/N)");
                check = Console.ReadLine().ToLower();
            }
            while (check != "n");
        }
        static bool IsPrime (int n)
        {
            int counter = 0;
            bool check = false ;
            if (n==2)
            {
                check = true;
            }
            if (n>2) 
            {
                for (int i = 2; i < Math.Sqrt(n); i++ )
                {
                   if (n%i==0)
                   {
                       counter++;
                   }
                }
            }
            if (counter==0)
            {
                check = true;
            }
            return check;
        }


    }
}
