using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;
using Zoo.BusinessLogic.Services;

namespace Zoo.ConsoleApp
{
    public class Program
    {
        public static void Main()
        {

            var prog = new Program();
            prog.mainloop();
            



            /* var largeAnimals = new ILargeAnimal[]
             {
               new Lion(new DateTime(2010, 4, 28)),
               new Lion(new DateTime(2012, 5, 11)),
               new Zebra(new DateTime(2008, 12, 1))
             };
             var smallAnimals = new ISmallAnimal[] {
               new Rabbit(new DateTime(2014, 1, 1)),
             };
             var animals = largeAnimals.Union<IAnimal>(smallAnimals).ToList();

             var largeAnimalKeeper = new Keeper<ILargeAnimal>(largeAnimals);
             var smallAnimalKeeper = new Keeper<ISmallAnimal>(smallAnimals);

             var keepers = new IKeeper[]
             {
               largeAnimalKeeper,
               smallAnimalKeeper 
             };

             var babyRabbit = new Rabbit(DateTime.Today);
             smallAnimalKeeper.StartLookingAfter(babyRabbit);

             var feedingScheduler = FeedingScheduler.Instance;
             var groomingScheduler = GroomingScheduler.Instance;

             while (true)
             {
               Console.WriteLine("Feeding the animals...");
               feedingScheduler.AssignFeedingJobs(keepers, animals);

               Console.WriteLine("Grooming the animals...");
               groomingScheduler.AssignGroomingJobs(keepers, animals);

               Console.WriteLine("Done. Results:");

               foreach (var animal in animals)
               {
                 Console.WriteLine(animal);
               }

               Console.WriteLine();
               Thread.Sleep(1000);
             }
       */
        }

       public void mainloop()
        {
            while (true)
            {
                Console.WriteLine("Planting eden..");
                var eden = new Orchard();

                Console.WriteLine("Success.");
                Console.WriteLine("Initializing forbidden fruit...");
                var fruitful = new Counter<cart<apple>>();

                Console.WriteLine("Success.");
                Console.WriteLine("Locating Tree of knowledge...");
                var TreeOfKnowledge = eden.GenoCider();
                Console.WriteLine("Success.");

                Console.WriteLine("Commencing fall...");
                foreach (var cart in TreeOfKnowledge)
                {
                    fruitful.Add(cart);
                }

                Console.WriteLine($"manual count of casualties : {eden.countApplesula}");
                Console.WriteLine($"fruitful count of casualties : {fruitful.Count}");

                Console.WriteLine("Press any key to beggin new universe...");
                Console.ReadLine();
            }
        }
    }
}
