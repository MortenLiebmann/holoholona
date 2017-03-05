using Holoholona.Entities.Enums;

namespace Holoholona.Web.Models
{
    interface IAnimal
    {
        int Id { get; set; }
        string Name { get; set; }
        AnimalTypeEnum Type { get; set; }
    }
}
