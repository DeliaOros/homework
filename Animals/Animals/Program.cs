using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Eagle eagle = new Eagle("Val", AnimalCategories.bird);
            Console.WriteLine(eagle);
            eagle.Swim();
            eagle.Fly();
            eagle.Move();
            eagle.Walk();

            Console.WriteLine("--------------------------------------------");

            Platypus platypus = new Platypus("Orni",AnimalCategories.mammal);
            Console.WriteLine(platypus);           
            platypus.Move();
            platypus.Swim();
            platypus.Walk();

            Console.WriteLine("---------------------------------------------");


            WildDuck wildDuck = new WildDuck("Donald", AnimalCategories.bird);
            Console.WriteLine(wildDuck);
            wildDuck.Fly();
            wildDuck.Move();
            wildDuck.Swim();
            wildDuck.Walk();


            Console.WriteLine("----------------------------------------------");

            Crocodile aligator = new Crocodile("Aligator", AnimalCategories.reptile);
            Console.WriteLine(aligator);
            aligator.Crawl();
            aligator.Move();
            aligator.Swim();
            aligator.Walk();
            


            




        }







    }
}

