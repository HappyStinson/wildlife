using System;
using System.Collections.Generic;
using Wildlife.Animalia;
using Wildlife.Animalia.Aves;

namespace Wildlife
{
    class Program
    {
        static void Main(string[] args)
        {
            var flamingo = new Flamingo("Pink Flamingo", wingSpan: 1.4,
                reproduction: "Nests consist of a low platform of dirt, built amongst a breeding colony.Females lay a single egg.");

            var pelican = new Pelican("American Sea Pelican", wingSpan: 3.5,
                fact: "Australian pelicans will occasionally eat other birds such as silver gulls or grey teals or even small dogs.");

            List<Animal> animals = new List<Animal>();
            animals.Add((new Animal("Human", "Homosapiens")));
            animals.Add(new Bird());
            animals.Add(new Bird("Pidgeon", wingSpan: 0.3));
            animals.Add(new Swan());
            animals.Add(new Swan("Black Swan", wingSpan: 1.6, speed: 12));
            animals.Add(new Flamingo());
            animals.Add(flamingo);
            animals.Add(new Pelican());
            animals.Add(pelican);
            animals.Add(new Worm());
            animals.Add(new Worm("Earthworm", 0.1));
            animals.Add(new Hedgehog());
            animals.Add(new Hedgehog("Spiked Hedgehog", habitat: "Australia"));
            animals.Add(new Horse());
            animals.Add(new Horse("Black Stallion", breed: "Full Blood"));

            Console.WriteLine("Welcome to the animal kindgom: Wildlife!");
            Console.WriteLine("\nSHOWING ALL ANIMALS:");
            Console.WriteLine("--------------------");
            PrintElements(animals);

            Console.ReadKey();
            Console.Clear();

            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog());
            var dog = new Dog("Pitbull", domestic: false);
            dogs.Add(dog);
            // dogs.Add(new Horse());
            Console.WriteLine("SHOWING ALL DOGS:");
            Console.WriteLine("-----------------");
            PrintElements(dogs);
            Console.WriteLine($"Making {dog.Species} my pet.\n");
            dog.MakeDomestic();
            Console.WriteLine(dog.DomesticInfo());

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("SHOWING ALL BIRDS:");
            Console.WriteLine("------------------");
            PrintElements(animals, taxonomyClass: "Aves");

            // FRÅGOR
            // Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
            // Svar: Det går inte att konvertera en Horse att passa mallen för klass Dog eftersom det är olika klasser.

            // Vilken typ måste listan lagra för att dessa tre nya klasser ska kunna lagras tillsammans?
            // Svar: Pelican, Flamingo och Swan måste lagras i en lista av typen Bird vilket är den gemensamma basklassen.

            // Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
            // Svar: Typen Animal krävs för att lagra alla olika djur i samma lista eftersom det är den gemensamma basklass som alla djur ärver ifrån.

            // Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?
            // Svar: Om ändringen gäller samtliga fåglar ska det ändras i Bird för att bara ändra på ett ställe.

            // Om alla djur behöver det nya attributet, vart skulle man lägga det då?
            // Svar: Om ändringen gäller samtliga djur ska det ändras i Animal för att bara ändra på ett ställe.
        }

        private static void PrintElements(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
                Console.WriteLine();
            }
        }

        private static void PrintElements(List<Dog> dogs)
        {
            foreach (var dog in dogs)
            {
                Console.WriteLine(dog);
                Console.WriteLine();
            }
        }

        private static void PrintElements(List<Animal> animals, string taxonomyClass)
        {
            foreach (var animal in animals)
            {
                if (animal.Class == taxonomyClass)
                {
                    Console.WriteLine(animal);
                    Console.WriteLine();
                }
            }
        }
    }
}