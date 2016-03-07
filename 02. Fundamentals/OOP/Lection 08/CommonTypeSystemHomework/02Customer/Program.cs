using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Customer
{
    class Program
    {

        private static void Main()
        {
            var forNext = new Payment("Ten", 10);

            var aleks = new Customer(
                "Aleks",
                "Dimitrov",
                7708091215,
                0897588666,
                "aleksa@abv.bg",
                CustomerType.OneTime,
                forNext);

            var dimitar = aleks.Clone() as Customer;
            dimitar.FirstName = "Dimityr";
            dimitar.LastName = "Liroy";

            Console.WriteLine(dimitar);
            Console.WriteLine(aleks);

            var georgi = new Customer(
                "Georgi",
                "Vinin",
                8609085256,
                0898528525,
                "Gosheto@gmail.com",
                CustomerType.Diamond);

            var todor = georgi.Clone() as Customer;
            todor.Id = 5606081218;
            todor.LastName = "Ivanov";

            var customers = new List<Customer> { aleks, dimitar, georgi, todor };
            customers.Sort();

            Console.WriteLine("***************************");
            Console.WriteLine(string.Join("\n", customers));
        }
    }
}
    