using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01Persons
{
    class PersonsMain
    {
        static void Main()
        {
            Person a = new Person("Pesho", 7);
            Person b = new Person("Gosho", 15, "gosho@softuni.bg");
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
