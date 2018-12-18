using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Eagle : Animal, IFly, ISwim, IWalk
    {
        int IFly.MaxSpeed { get { return flySpeed; } set { flySpeed = value; } }
        int ISwim.MaxSpeed { get { return swimmSpeed; } set { swimmSpeed = value; } }
        int IWalk.MaxSpeed { get { return walkSpeed; } set { walkSpeed = value; } }

        int flySpeed = 80;
        int swimmSpeed = 10;
        int walkSpeed = 15;

        public override AnimalCategories Cathegory { get { return this.category; } set { category = value; } }
        public override void Move()
        {
            Console.WriteLine($"{this.Name} can move.");
        }

        public void Fly()
        {
            Console.WriteLine($"{this.Name} mainly flies, at high altitude.");
        }

        public void Swim()
        {
            Console.WriteLine($"{this.Name} rarely swimms.");
        }

        public void Walk()
        {
            Console.WriteLine($"{this.Name} sometimes walks.");
        }
        public Eagle(string name) : base(name)
        {

        }
        public Eagle(string name, AnimalCategories category)
            : this(name)
        {
            Cathegory = category;

        }
        public override string ToString()
        {
            return $"{this.Name} fails in \"{this.Cathegory}\" category.\n" +
                $"{this.Name} maximum speed: can fly at {flySpeed} km/h, walk at {walkSpeed} km/h and swimm at {swimmSpeed} km/h.";
        }
    }
}
