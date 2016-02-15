using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04MagicStrings
{
    class Program
    {
        static void Main()
        {
            int diff = int.Parse(Console.ReadLine());
            char[] letters = { 'k', 'n', 'p', 's' };
            int[] nums = { 1, 4, 5, 3 };
            if (diff>16 || diff<0)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i1 =0; i1<4; i1++)
                {
                    for (int i2 = 0; i2 < 4; i2++)
                    {
                        for (int i3 = 0; i3 < 4; i3++)
                        {
                            for (int i4 = 0; i4 < 4; i4++)
                            {
                                for (int i5 = 0; i5 < 4; i5++)
                                {
                                    for (int i6 = 0; i6 < 4; i6++)
                                    {
                                        for (int i7 = 0; i7 < 4; i7++)
                                        {
                                            for (int i8 = 0; i8 < 4; i8++)
                                            {
                                                if (nums[i1]+nums[i2]+nums[i3]+nums[i4]==nums[i5]+nums[i6]+nums[i7]+nums[i8]+diff)
                                                {
                                                    Console.Write(letters[i1]);
                                                    Console.Write(letters[i2]);
                                                    Console.Write(letters[i3]);
                                                    Console.Write(letters[i4]);
                                                    Console.Write(letters[i5]);
                                                    Console.Write(letters[i6]);
                                                    Console.Write(letters[i7]);
                                                    Console.WriteLine(letters[i8]);
                                                }
                                                if (nums[i1] + nums[i2] + nums[i3] + nums[i4] + diff == nums[i5] + nums[i6] + nums[i7] + nums[i8])
                                                {
                                                    Console.Write(letters[i1]);
                                                    Console.Write(letters[i2]);
                                                    Console.Write(letters[i3]);
                                                    Console.Write(letters[i4]);
                                                    Console.Write(letters[i5]);
                                                    Console.Write(letters[i6]);
                                                    Console.Write(letters[i7]);
                                                    Console.WriteLine(letters[i8]);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
