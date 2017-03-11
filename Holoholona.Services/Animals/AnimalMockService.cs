using System.Collections.Generic;
using System;
using Holoholona.Entities;
using static Holoholona.Entities.Enums.AnimalEnums;

namespace Holoholona.Services.Animals
{
    public class AnimalMockService : IAnimalService
    {
        public Animal GetAnimal(int id)
        {
            foreach (Animal item in GetAnimals())
            {
                if (item.Id == id) return item;
            }
            throw new IndexOutOfRangeException("Animal does not exist");
        }

        public List<Animal> GetAnimals()
        {
            //todo: use animal repository
            Animal a1 = new Animal() { Id = 1, Name = "Chihuahua", Type = AnimalType.Small };
            Animal a2 = new Animal() { Id = 2, Name = "Siamese", Type = AnimalType.Small };
            List<Animal> lst = new List<Animal>();
            lst.AddRange(new List<Animal> { a1, a2 });

            return lst;
        }
    }
}