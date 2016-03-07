using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Square_Root
{
    class Square
    {
        static void Main()
        {
            string numberInString = Console.ReadLine();
            int number;
            try
            {
                number = int.Parse(numberInString);
                double answer = SquareRoot.Calculate(number);
                Console.WriteLine(answer);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
                
        }
    }
}
