using Holoholona.Models;
using System.Collections.Generic;

namespace Holoholona.Repositories.AnimalRepository
{
    interface IAnimalRepository
    {
        Animal GetAnimal(int id);

        List<Animal> GetAnimals();
    }
}