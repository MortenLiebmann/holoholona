using System;
using System.Collections.Generic;
using Holoholona.Entities;
using Holoholona.Services.Repositories;
using static Holoholona.Entities.Enums.AnimalEnums;

namespace Holoholona.Services.Players
{
    class PlayerMockService : IPlayerService
    {
        public Player GetPlayer(int id)
        {
            AnimalRepositoryMock ARM = new AnimalRepositoryMock();
            List<Animal> randomAnimals = ARM.getAnimals();

            //todo: move to itemsrepository
            Item i1 = new Item() { Id = 1, Name = "Bait" };

            return new Player() {
                Id = 1,
                Name = "Morten",
                Animals = randomAnimals,
                AnimalsOnCharacter = randomAnimals,
                Money = 45,
                Level = 1,
                Experience = 0,
                items = new List<Item> { i1 }
            };
        }
    }
}