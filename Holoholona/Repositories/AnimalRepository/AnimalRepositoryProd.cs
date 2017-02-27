using System;
using System.Collections.Generic;
using Holoholona.Models;

namespace Holoholona.Repositories.AnimalRepository
{
    public class AnimalRepositoryProd : IAnimalRepository
    {
        public Animal GetAnimal(int id)
        {
            throw new NotImplementedException();
        }

        public List<Animal> GetAnimals()
        {
            throw new NotImplementedException();
        }
    }
}