using System.Collections.Generic;
using Holoholona.Models;
using Holoholona.Models.Enums;

namespace Holoholona.Repositories.AnimalRepository
{
    public class AnimalRepositoryMock : IAnimalRepository
    {
        public Animal GetAnimal(int id)
        {
            foreach (var item in GetAnimals())
            {
                if (item.Id == id) return item;
            }
            throw new KeyNotFoundException("Animal was not found");
        }

        public List<Animal> GetAnimals()
        {
            Animal a1 = new Dog() { Id = 1, Name = "Chihuahua", Type = AnimalTypeEnum.Mammal };
            Animal a2 = new Dog() { Id = 2, Name = "Bulldog", Type = AnimalTypeEnum.Mammal };
            List<Animal> lst = new List<Animal>();
            lst.Add(a1);
            lst.Add(a2);
            return lst;
        }
    }
}