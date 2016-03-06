using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03CategorizeNumbers
{
    class CategorizeNumbers
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputmass = input.Split(' ');
            List <int> intList = new List<int>();
            List<double> doubleList = new List<double>();
            for (int i = 0; i < inputmass.Length; i++)
            {
                double temp = double.Parse(inputmass[i]);
                if (temp%1==0)
                {
                    intList.Add((int)temp);
                }
                else
                {
                    doubleList.Add(temp);
                }          
            }
            Console.WriteLine("[ {0} ] -> min: {1}, max: {2}, sum: {3}, avg: {4:0.00}", 
                string.Join(", ", doubleList), doubleList.Min(), doubleList.Max(), doubleList.Sum(), doubleList.Average());
            Console.WriteLine("[ {0} ] -> min: {1}, max: {2}, sum: {3}, avg: {4:0.00}",
                string.Join(", ", intList), intList.Min(), intList.Max(), intList.Sum(), intList.Average());
        }
    }
}
