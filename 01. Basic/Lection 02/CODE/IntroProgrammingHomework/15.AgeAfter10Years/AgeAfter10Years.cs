using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main()
        {
            
            Console.WriteLine("Enter your birthday in mm/dd/yyyy format!");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            var age = DateTime.Today.Subtract(birthday).Ticks;
            Console.WriteLine("You are {0} years old.", new DateTime(age).Year - 1);
            Console.WriteLine("After 10 years uou will be {0} years old.", new DateTime(age).AddYears(10).Year - 1);

        }
       
    }
}
