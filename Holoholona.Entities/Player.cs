using System.Collections.Generic;
namespace Holoholona.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Animal> Animals { get; set; }
        public List<Animal> AnimalsOnCharacter { get; set; }
        public int Money { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public List<Item> items { get; set; }
    }
}