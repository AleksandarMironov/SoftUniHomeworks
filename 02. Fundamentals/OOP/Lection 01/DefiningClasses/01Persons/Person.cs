using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Persons
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentNullException("Empty name!");
                }
                if (value.Trim() == "")
                {
                    throw new AggregateException("Rong Name!");
                }
                this.name = value;              
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Age must by in range 1-100");
                }
                this.age = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value != String.Empty )
                {
                    if (!value.Contains("@") && value.Count()<3)
                    {
                        throw new ArgumentException("Invalid E-Mail!");
                    }
                }
                this.email = value;
            }
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public override string ToString()
        {
            return string.Format("Name = {0}, Age = {1}, Email = {2}", this.Name, this.Age, this.Email ?? "No email");
        }
    }
}





