﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03PCCatalog
{
    class Computer
    {
        private string name;
        private List<Component> components;

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
        public List<Component> Components
        {
            get
            {
                return this.components;
            }
            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentNullException("Computer can not be without  components!");
                }
                this.components = value;
            }
        }
        public decimal Price
        {
            get
            {
                return Calculate(this);
            }
        }

        public Computer(string name, List<Component> components)
        {
            this.Name = name;
            this.Components = components;
        }

        public static decimal Calculate(Computer computer)
        {
            var components = computer.Components;
            decimal price = 0;
            foreach (var component in components)
            {
                price += component.Price;
            }
            return price;
        }
        public override string ToString()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg");
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("Computer name: {0}", this.Name));
            foreach (var component in this.Components)
            {
                result.AppendLine(string.Format("{0}{2} {1:c2}", component.Name, component.Price, string.IsNullOrWhiteSpace(component.Details) ? ":" : ":" + " " + component.Details + ":"));
            }
            result.AppendLine(string.Format("Total price: {0:c2}", this.Price));
            return result.ToString();
        }
    }
}
