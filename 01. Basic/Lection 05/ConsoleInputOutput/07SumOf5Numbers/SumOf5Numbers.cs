using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main()
        {
            string[] nums = Console.ReadLine().Split(' ');
            double num1 = double.Parse(nums[0]);
            double num2 = double.Parse(nums[1]);
            double num3 = double.Parse(nums[2]);
            double num4 = double.Parse(nums[3]);
            double num5 = double.Parse(nums[4]);
            Console.WriteLine("Sum={0}", num1+num2+num3+num4+num5);
        }
    }
}
