using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class WildDuck:Animal,IFly,IWalk,ISwim
    {
        int IFly.MaxSpeed { get { return maxFlySpeed; } set { maxFlySpeed = value; } }
        int ISwim.MaxSpeed { get { return maxSwimmSpeed; } set { maxSwimmSpeed = value; } }
        int IWalk.MaxSpeed { get { return maxWalkSpeed; } set { maxWalkSpeed = value; } }
        int maxFlySpeed = 15;
        int maxSwimmSpeed = 30;
        int maxWalkSpeed = 5;

        public override AnimalCategories Cathegory { get { return this.category; } set { category = value; } }
        public override void Move()
        {
            Console.WriteLine($"{this.Name} can move.");
        }

        public void Fly()
        {
            Console.WriteLine($"{this.Name} flies.");
        }

        public void Swim()
        {
            Console.WriteLine($"{this.Name} swimms.");
        }

        public void Walk()
        {
            Console.WriteLine($"{this.Name} sometimes walks.");
        }
        public WildDuck(string name) : base(name)
        {

        }
        public WildDuck(string name, AnimalCategories category)
            : this(name)
        {
            Cathegory = category;

        }
        public override string ToString()
        {
            return $"{this.Name} fails in \"{this.Cathegory}\" category.\n" +
                $"{this.Name} maximum speed: can fly at {maxFlySpeed} km/h, walk at {maxWalkSpeed} km/h and swimm at {maxSwimmSpeed} km/h.";
        }
    }
}

