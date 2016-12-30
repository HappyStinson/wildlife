using System;
using System.Collections.Generic;

namespace Wildlife
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Bird());
            animals.Add(new Hedgehog());
            animals.Add(new Dog());
            animals.Add(new Hedgehog());
            animals.Add(new Horse());
            animals.Add(new Hedgehog());
            animals.Add(new Worm());
            animals.Add(new Hedgehog());

            Console.WriteLine("Animals in kingdom:");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Species);
            }
        }
    }
}
