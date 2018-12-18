using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Crocodile : Animal, ICrawl, IWalk, ISwim
    {
        int ICrawl.MaxSpeed { get { return maxCrawlSpeed; } set { maxCrawlSpeed = value; } }
        int ISwim.MaxSpeed { get { return maxSwimmSpeed; } set { maxSwimmSpeed = value; } }
        int IWalk.MaxSpeed { get { return maxWalkSpeed; } set { maxWalkSpeed = value; } }

        int maxCrawlSpeed = 30;
        int maxSwimmSpeed = 60;
        int maxWalkSpeed = 40;

        public override AnimalCategories Cathegory { get { return this.category; } set { category = value; } }

        public override void Move()
        {
            Console.WriteLine($"{this.Name} can move.");
        }

        public void Crawl()
        {
            Console.WriteLine($"{this.Name} crawls.");
        }

        public void Swim()
        {
            Console.WriteLine($"{this.Name} mainly swimms.");
        }

        public void Walk()
        {
            Console.WriteLine($"{this.Name} sometimes walks.");
        }
        public Crocodile(string name) : base(name)
        {

        }
        public Crocodile(string name, AnimalCategories category)
            : this(name)
        {
            Cathegory = category;

        }
        public override string ToString()
        {
            return $"{this.Name} fails in \"{this.Cathegory}\" category.\n" +
                $"{this.Name} maximum speed: can crawl at {maxCrawlSpeed} km/h, walk at {maxWalkSpeed} km/h and swimm at {maxSwimmSpeed} km/h.";
        }
    }

}

