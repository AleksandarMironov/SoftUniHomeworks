using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main()
        {
            Console.WriteLine("Enter num:");
            int num = int.Parse(Console.ReadLine());
            int tirdDig = num / 100 % 10;
            bool chek = (tirdDig == 7);
            Console.WriteLine("The third digit from right-to-left is 7:  {0}", chek);
        }
    }
}
