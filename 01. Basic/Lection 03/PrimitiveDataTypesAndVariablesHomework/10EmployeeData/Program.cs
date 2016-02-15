using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10EmployeeData
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Gender:");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter ID:");
            ulong id = ulong.Parse(Console.ReadLine());
            Console.Write("Enter Employee Number: \n275");
            ushort emplNumber = ushort.Parse(Console.ReadLine());
            Console.WriteLine("\n\n\n Name: {0} {1} \n Age: {2} years old \n Gender: {3}\n ID: {4} \n Unique employee number: 275{5}",
                                firstName, lastName, age, gender, id, emplNumber);
        }
    }
}
