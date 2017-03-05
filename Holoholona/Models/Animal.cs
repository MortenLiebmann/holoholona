﻿using Holoholona.Entities.Enums;

namespace Holoholona.Web.Models
{
    public class Animal : IAnimal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public AnimalTypeEnum Type { get; set; }
    }
}