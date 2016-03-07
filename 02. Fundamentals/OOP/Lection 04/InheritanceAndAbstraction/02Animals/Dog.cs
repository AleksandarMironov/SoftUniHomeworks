﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals;

namespace _02Animals
{
    class Dog:Animal
    {
        public Dog(string name, int age)
            : base(name, age)
        {
        }

        public override string ToString()
        {
            {
                return string.Format("Name: {0}, Age: {1}", this.Name, this.Age);
            }
        }

        public override void ProducedSound()
        {
            Console.WriteLine("Bau");
        }
    }
}
