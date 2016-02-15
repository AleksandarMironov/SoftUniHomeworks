using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        static void Main()
        {
            
            int[] mass = { 1, 0, 0, 0, 0, 0, 0, 0 };
            string input = Console.ReadLine();
            int massIndex = 0;
            int maskIndex = 0;
            while (input != "stop")
            {
                string[] direction = input.Split();
                int tempMassIndex = 0;
                int tempMaskIndex = 0;
                int mask = 1;
                if (direction[0] == "left")
                {
                    tempMaskIndex = maskIndex + 2;
                }
                if (direction[0] == "right")
                {
                    tempMaskIndex = maskIndex - 2;

                } 
                if (direction[0] == "up")
                {
                    tempMassIndex = massIndex - 2;
                } 
                if (direction[0] == "down")
                {
                    tempMassIndex = massIndex + 2;

                }
                if (direction[1] == "left")
                {
                    tempMaskIndex = maskIndex + 1;

                }
                if (direction[1] == "right")
                {
                    tempMaskIndex = maskIndex - 1;

                }
                if (direction[1] == "up")
                {
                    tempMassIndex = massIndex - 1;

                }
                if (direction[1] == "down")
                {
                    tempMassIndex = massIndex + 1;

                }

                if (tempMassIndex>=0 && tempMassIndex<8 && tempMaskIndex>=0 && tempMaskIndex<8)
                {
                    massIndex = tempMassIndex;
                    maskIndex = tempMaskIndex;
                    if (maskIndex != 0)
                    {
                        mask = mask << maskIndex;
                    }
                    mass[massIndex] = mass[massIndex] ^ mask;
                }



                input = Console.ReadLine();
            }
            int counter = 0;
            foreach (int num in mass)
            {
                if (num!=0)
                {
                    Console.WriteLine(num);
                    counter++;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("[Board is empty]");
            }
        }
    }
}
