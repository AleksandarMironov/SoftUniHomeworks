using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _18PINValidation
{
    class Program
    {
        static void Main()
        {
            bool validation = true;
            string name = Console.ReadLine();
            string gender = Console.ReadLine();
            string egnString = Console.ReadLine();
            int[] mass = new int[egnString.Length];
            for (int i = 0; i < egnString.Length; i++)
            {
                mass[i] = int.Parse(egnString[i].ToString());
            }
            if (mass[8]%2 == 0 && gender == "female")
            {
                validation = false;
            }
            if (mass[8]%2 == 1 && gender == "male")
            {
                validation = false;
            }
            int checksum = (mass[0]*2 + mass[1]*4 + mass[2]*8 + mass[3]*5 + mass[4]*10 + mass[5]*9 + mass[6]*7 +
                            mass[7]*3 + mass[8]*6)%11;
            if (checksum != mass[9] || mass[2] > 5 || mass[4] >3)
            {
                validation = false;
            }
            if (gender != "male" && gender != "female")
            {
                validation = false;
            }
            string pattern = @"^[A-Z][a-z]+ [A-Z][a-z]+$";
            Regex regex = new Regex(pattern);
            if (!regex.IsMatch(name))
            {
                validation = false;
            }
            if (validation == true)
            {
                Console.WriteLine("{{\"name\":\"{0}\",\"gender\":\"{1}\",\"pin\":\"{2}\"}}", name, gender, egnString);
            }
            if (validation == false)
            {
                Console.WriteLine(@"<h2>Incorrect data</h2>");
            }
        }
    }
}
