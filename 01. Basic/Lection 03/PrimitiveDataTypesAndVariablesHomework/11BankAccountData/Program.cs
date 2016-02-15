using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11BankAccountData
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Midle Name:");
            string midleName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Balance Amount");
            decimal balance = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Bank Name:");
            string bankName = Console.ReadLine();
            Console.WriteLine("Enter IBAN:");
            string iban = Console.ReadLine();
            Console.WriteLine("Enter Main Credit Card Number:");
            string creditCard1 = Console.ReadLine();
            string creditCard2 = null;
            string creditCard3 = null;
            Console.WriteLine("Is there second credit card? (y/n)");
            char check = char.Parse(Console.ReadLine());
            if (check == 'y')
            {
                Console.WriteLine("Enter Second Credit Card Number:");
                creditCard2 = Console.ReadLine();
                Console.WriteLine("Is there tird credit card? (y/n)");
                check = char.Parse(Console.ReadLine());
                if (check == 'y')
                {
                    Console.WriteLine("Enter Tird Credit Card Number:");
                    creditCard3 = Console.ReadLine();
                }

            }
            Console.WriteLine(" Name: {0} {1} {2}\n Balance: {3} € \n Bank name: {4} \n IBAN: {5} \n Credit card numbers: {6} \n {7} \n {8}",
                                firstName, midleName, lastName, balance, bankName, iban, creditCard1, creditCard2, creditCard3);


        }
    }
}
