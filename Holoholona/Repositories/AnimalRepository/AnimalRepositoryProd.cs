using System;
using System.Collections.Generic;
using Holoholona.Web.Models;

namespace Holoholona.Web.Repositories.AnimalRepository
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