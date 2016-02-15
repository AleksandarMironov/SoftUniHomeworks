using System;

namespace December_Lab
{
    class Beers
    {
        static void Main()
        {
            string line = Console.ReadLine();

            int beerCount = 0;
            while (line != "End")
            {
                string[] data = line.Split(' ');
                int count = int.Parse(data[0]);
                string type = data[1];
                
                if (type == "beers")
                {
                    beerCount += count;
                }
                else 
                {
                    beerCount += count * 20;
                }

                line = Console.ReadLine();  
            }

            int totalStacks = beerCount / 20;
            int leftBeers = beerCount % 20;
            Console.WriteLine("{0} stacks + {1} beers", totalStacks, leftBeers);
        }
    }
}
