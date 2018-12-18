using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Platypus : Animal, ISwim, IWalk
    {

        int ISwim.MaxSpeed { get { return swimmSpeed; } set { swimmSpeed = value; } }
        int IWalk.MaxSpeed { get { return walkSpeed; } set { walkSpeed = value; } }

        int swimmSpeed = 20;
        int walkSpeed = 10;

        public override AnimalCategories Cathegory { get { return this.category; } set { category = value; } }

        public void Swim()
        {
            Console.WriteLine($"{this.Name} mainly swimms.");
        }

        public void Walk()
        {
            Console.WriteLine($"{this.Name} sometimes walks.");
        }
        public Platypus(string name) : base(name)
        {

        }
        public Platypus(string name, AnimalCategories category)
            : this(name)
        {
            Cathegory = category;

        }
        public override void Move()
        {
            Console.WriteLine($"{this.Name} can move.");
        }
        public override string ToString()
        {
            return $"{this.Name} fails in \"{this.Cathegory}\" category.\n" +
                $"{this.Name} maximum speed: can walk at {walkSpeed} km/h and swimm at {swimmSpeed} km/h.";
        }
    }
}
