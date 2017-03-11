using Holoholona.Entities;
using System;
using System.Collections.Generic;
using static Holoholona.Entities.Enums.AnimalEnums;

namespace Holoholona.Services.Repositories
{
    class AnimalRepositoryMock
    {
        public List<Animal> getAnimals() {
            Random rand = new Random();
            List<Animal> animalList = new List<Animal>();

            for (int i = 0; i < rand.Next(1, 5); i++) {
                Animal a = new Animal() { Id = i, Name = "Animal " + i, Type = AnimalType.Small };
                animalList.Add(a);
            }

            return animalList;
        }
    }
}