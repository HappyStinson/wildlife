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