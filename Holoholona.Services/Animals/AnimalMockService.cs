using System.Collections.Generic;
using System;
using Holoholona.Entities;
using Holoholona.Entities.Enums;
using Holoholona.Entities.Animals;

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
            Animal a1 = new Dog() { Id = 1, Name = "Chihuahua", Type = AnimalTypeEnum.Mammal };
            Animal a2 = new Dog() { Id = 2, Name = "Siamese", Type = AnimalTypeEnum.Mammal };
            List<Animal> lst = new List<Animal>();
            lst.AddRange(new List<Animal> { a1, a2 });

            return lst;
        }
    }
}