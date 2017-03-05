using Holoholona.Web.Models;
using System.Collections.Generic;

namespace Holoholona.Web.Repositories.AnimalRepository
{
    interface IAnimalRepository
    {
        Animal GetAnimal(int id);

        List<Animal> GetAnimals();
    }
}