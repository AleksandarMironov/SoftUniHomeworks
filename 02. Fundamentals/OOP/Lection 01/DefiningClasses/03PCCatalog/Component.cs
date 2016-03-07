﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03PCCatalog
{
    class Component
    {
        private string name;
        private decimal price;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty!");
                }
                this.name = value;
            }
        }
        public string Details { get; set; }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative!");
                }
                this.price = value;
            }
        }

        public Component(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public Component(string name, decimal price, string details)
            : this(name, price)
        {
            this.Details = details;
        }
    }
}
