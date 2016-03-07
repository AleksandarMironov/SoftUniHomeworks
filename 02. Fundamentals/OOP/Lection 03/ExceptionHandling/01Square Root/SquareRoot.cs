using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Square_Root
{
    class SquareRoot
    {
        //private  int number;

        //public int Number
        //{
        //    get { return this.number; }
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            throw new ArgumentOutOfRangeException("Entered number must be greater than 0");
        //        }
        //        this.number = value;
        //    }
        //}

        //public SquareRoot()
        //{
        //    this.Number = number;
        //}

        public static double Calculate(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Entered number must be greater than 0");
            }
            return Math.Sqrt(number);
        }
    }
}
