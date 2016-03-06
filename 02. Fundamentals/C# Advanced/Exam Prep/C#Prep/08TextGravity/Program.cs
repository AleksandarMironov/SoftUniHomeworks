using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _08TextGravity
{
    class Program
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int addToArreyLenght = 0;
            if (input.Length > 0)
            {
                if (input.Length%length != 0)
                {
                    addToArreyLenght = length - input.Length%length;
                }
            }
            char[] arrey = input.PadRight(input.Length + addToArreyLenght, ' ').ToCharArray();
            int rolls = arrey.Count()/length;
            for (int i = arrey.Count()-1; i > arrey.Count()-length-1; i--)
            {
                char temp = ' ';
                for (int j = 0; j <rolls; j++)
                {
                    if (arrey[i-length*j] == ' ')
                    {
                        int tempCount = j;
                        while (tempCount<rolls-1 && arrey[i-length*tempCount]==' ')
                        {
                            tempCount++;
                        }
                        temp = arrey[i - length * tempCount];
                        arrey[i - length*j] = temp;
                        arrey[i - length*tempCount] = ' ';
                    }
                }
            }
            Console.Write("<table>");
            for (int i = 0; i < arrey.Length; i++)
            {
                if (i%length == 0)
                {
                    Console.Write("<tr>");
                }
                Console.Write("<td>{0}</td>", SecurityElement.Escape(arrey[i].ToString()));
                if ((i+1) % length == 0)
                {
                    Console.Write("</tr>");
                }
            }
            Console.Write("</table>");


        }
    }
}
