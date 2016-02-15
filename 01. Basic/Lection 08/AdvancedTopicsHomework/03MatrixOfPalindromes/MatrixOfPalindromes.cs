using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cow = int.Parse(Console.ReadLine());
            for (int i=0; i<rows; i++)
            {
                for (int k=0; k<cow; k++)
                {
                    Console.Write((char)(i +'a'));
                    Console.Write((char)(k + i + 'a'));
                    Console.Write((char)(i + 'a'));
                    Console.Write(" ");
                }
                Console.WriteLine("\n\r");
            }
        }
    }
}
