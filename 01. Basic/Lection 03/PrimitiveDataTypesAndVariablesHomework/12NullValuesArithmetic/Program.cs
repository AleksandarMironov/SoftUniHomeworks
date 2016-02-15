using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12NullValuesArithmetic
{
    class Program
    {
        static void Main()
        {
            int? firstVar = null;
            double? secondVar = null;
            Console.WriteLine("Do you want to add values to first variable? (y/n)");
            char check = char.Parse(Console.ReadLine());
            if (check == 'y')
            {
                Console.WriteLine("Enter first number:");
                firstVar = int.Parse(Console.ReadLine());
                Console.WriteLine("Do you want to add values to second variable? (y/n)");
                check = char.Parse(Console.ReadLine());
                if (check == 'y')
                {
                    Console.WriteLine("Enter Tird Credit Card Number:");
                    secondVar = double.Parse(Console.ReadLine());
                }

            }
            Console.WriteLine("You enterd:\n {0} \n {1}", firstVar, secondVar);
        }
    }
}
