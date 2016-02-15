using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main()
        {
            Console.WriteLine("Enter start and end numbers:");
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            List<int> theList = FindPrimesInRange(startNum, endNum);
            string output = string.Join(",", theList.ToArray());
            if (theList.Count==0)
            {
                Console.WriteLine("(empty list)");
            }
            Console.WriteLine(output);

        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> tempList = new List<int>();
            for (int i = startNum; i <= endNum; i++ )
            {
                if (IsPrime(i))
                {
                    tempList.Add(i);
                }
            }

            return tempList;
        }



        static bool IsPrime(int n)
        {
            int counter = 0;
            bool check = false;
            if (n == 2)
            {
                check = true;
            }
            if (n > 2)
            {
                for (int i = 2; i < Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        counter++;
                    }
                }
            }
            if (counter == 0)
            {
                check = true;
            }
            if (n<2)
            {
                check = false;
            }
            return check;
        }
    }
}
