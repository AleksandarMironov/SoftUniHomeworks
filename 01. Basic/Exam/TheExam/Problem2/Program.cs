using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] mass = input.Split('\\');
            decimal moneyPerHour = decimal.Parse(mass[1]);
            int hoursPerDay = int.Parse(mass[2]);
            decimal priceOfItem = decimal.Parse(mass[3]);
            decimal income=0;
            switch (mass[0])
            {
                case "Jan":
                case "March":
                case "May":
                case "July":
                case "Aug":
                case "Oct":
                case "Dec":
                    {
                        income = 21 * moneyPerHour * hoursPerDay;
                      
                        break;
                    }
                case "Apr":
                case "June":
                case "Sept":
                case "Nov":
                    {
                        income = 20 * moneyPerHour * hoursPerDay;
                       
                        break;
                    }
                case "Feb":
                    {
                        income = 18 * moneyPerHour * hoursPerDay;
                      
                        break;
                    }
            }
            if(income>=700)
            {

                income = income+( income /10);
               
            }

            

            if (income>=priceOfItem)
            {

                Console.WriteLine("Money left = {0:0.00} leva.", income - priceOfItem);
            }
            if (priceOfItem>income)
            {

                Console.WriteLine("Not enough money. {0:0.00} leva needed.", priceOfItem - income);
            }

        }
    }
}
