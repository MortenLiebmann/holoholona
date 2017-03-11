using Holoholona.Entities.Enums;
using System;
using static Holoholona.Entities.Enums.AnimalEnums;

namespace Holoholona.Web.Models
{
    public class Animal
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public AnimalType Type { get; set; }
        public AnimalFamily Family { get; set; }
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public int Speed { get; set; }
        public int Defence { get; set; }
        public int Strength { get; set; }

        public int Attack(Attack attack)
        {
            return Strength * (attack.Damage / 100);
        }

        public void Hit(int dmg)
        {

        }
    }
}