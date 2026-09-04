using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment10
{
    internal class AnimalContainer<T> where T : Animal
    {
        List<T> animals = new List<T>();
        public void Add(T animal)
        {
            animals.Add(animal);
        }
        public void print()
        {
            foreach (T animal in animals)
            {
                Console.WriteLine(animal.Name);
            }

        }
    }
}