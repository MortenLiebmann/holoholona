using Holoholona.Entities.Enums;

namespace Holoholona.Entities
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public AnimalEnums.AnimalType Type { get; set; }
    }
}