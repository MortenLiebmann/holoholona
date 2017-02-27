using Holoholona.Models.Enums;

namespace Holoholona.Models
{
    interface IAnimal
    {
        int Id { get; set; }
        string Name { get; set; }
        AnimalTypeEnum Type { get; set; }
    }
}
