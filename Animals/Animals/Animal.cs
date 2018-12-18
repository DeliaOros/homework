using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public enum AnimalCategories { mammal, fish, bird, insect, reptile };

    abstract public class Animal
    {       

        private string name;

        public AnimalCategories category;

        abstract public AnimalCategories Cathegory { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (name.Length < 1)
                {
                    throw new ArgumentException("An animal's name must have set at least one letter for a valid name", "Name");
                }
                this.name = value;
            }
        }

        public Animal(string name)
        {
            if (name.Length < 1)
            {
                throw new ArgumentException("An animal's name must have at least one letter for a valid name", "Name");
            }
            else
            {
                this.name = name;
            }

        }

        public virtual void Move()
        {
            Console.WriteLine($"Any animal can move.");
        }

        public override string ToString()
        {
            return $"{this.Name} is {this.Cathegory} and it can move.";
        }

    }
}

