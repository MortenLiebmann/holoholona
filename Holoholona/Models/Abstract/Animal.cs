using Holoholona.Models.Enums;

namespace Holoholona.Models
{
    public abstract class Animal : IAnimal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public AnimalTypeEnum Type { get; set; }
    }
}