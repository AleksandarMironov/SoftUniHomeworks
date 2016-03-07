using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace _02LaptopShop
{
    class LaptopShopMain
    {
        static void Main()
        {
            Laptop firstLaptop = new Laptop("Asus", 1000m);
            Laptop secondLaptop = new Laptop("HP", 1500m, new Battery());
            firstLaptop.Processor = "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)";
            firstLaptop.Ram = 8;
            firstLaptop.GraphicsCard = "Intel HD Graphics 4400";
            firstLaptop.Hdd = 128;
            firstLaptop.Screen = @"13.3"" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display";
            secondLaptop.Processor = "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)";
            secondLaptop.Ram = 8;
            secondLaptop.GraphicsCard = "Intel HD Graphics 4400";
            secondLaptop.Screen = @"13.3"" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display"; 
            secondLaptop.Batt = new Battery("Penka", 3.5);
            Console.WriteLine(firstLaptop);
            Console.WriteLine(secondLaptop);
        }
    }
}
