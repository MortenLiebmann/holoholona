using Holoholona.Entities;
using System.Collections.Generic;

namespace Holoholona.Services.Animals
{
    public interface IAnimalService
    {
        Animal GetAnimal(int id);

        List<Animal> GetAnimals();
    }
}