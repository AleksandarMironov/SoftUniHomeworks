using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main()
        {
            Console.WriteLine("Enter Company name :");
            string companyName = Console.ReadLine();
            Console.WriteLine("Enter Company address :");
            string companyAddress = Console.ReadLine();
            Console.WriteLine("Enter Phone number :");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Fax number :");
            string faxNumber = Console.ReadLine();
            Console.WriteLine("Enter Web site :");
            string webSite = Console.ReadLine();
            Console.WriteLine("Enter Manager first name :");
            string managerFirstName = Console.ReadLine();
            Console.WriteLine("Enter Manager last name :");
            string managerLastName = Console.ReadLine();
            Console.WriteLine("Enter Manager age :");
            string managerAge = Console.ReadLine();
            Console.WriteLine("Enter Manager phone :");
            string managerPhone = Console.ReadLine();
            Console.WriteLine("\n\r {0} \n\r Address: {1} \n\r Tel. {2} \n\r Fax: {3} \n\r Web site: {4} \n\r Manager: {5}{6} (age: {7} Tel. {8})", companyName, companyAddress, phoneNumber, faxNumber, webSite, managerFirstName, managerLastName, managerAge, managerPhone);
        }
    }
}
