using Holoholona.Web.Models.Enums;

namespace Holoholona.Web.Models
{
    public abstract class Animal : IAnimal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public AnimalTypeEnum Type { get; set; }
    }
}