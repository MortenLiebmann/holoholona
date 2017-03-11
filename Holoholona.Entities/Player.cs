namespace Holoholona.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Animal[] Animals { get; set; }
        public Animal[] AnimalsOnCharacter { get; set; }
        public int Money { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public Item[] items { get; set; }
    }
}