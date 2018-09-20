using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>();
            animals.Add(new Animal("Lion", 150, 50));
            animals.Add(new Animal("Elephant", 550, 30));
            animals.Add(new Animal("Zebra", 100, 60));
            animals.Add(new Animal("Dog", 20, 40));
            animals.Add(new Animal("Cat", 10, 40));
            animals.Add(new Animal("Lizard", 1, 5));
            animals.Add(new Animal("John", 80, 20));
            animals.Add(new Animal("Whale", 9000, 50));
            animals.Add(new Animal("Bird", 0.5, 25));
            animals.Add(new Animal("Dinosaur", 350, 100));
            
            animals.Sort();
            animals.ForEach(Console.WriteLine);
        }
    }
}