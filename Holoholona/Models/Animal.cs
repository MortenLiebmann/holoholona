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

        public int Attack(Attack attack, Animal opponent)
        {
            Random rand = new Random();

            //((((2 * Level / 5 + 2) * AttackStat * AttackPower / DefenseStat) / 50) + 2) * STAB * Weakness / Resistance * RandomNumber / 100
            return ((((2 * Level / 5 + 2) * Strength * attack.Damage / opponent.Defence) / 50) + 2) * rand.Next(100) / 100 * (rand.Next(100) <= attack.CriticalHitChance ? 2 : 1);
        }

        public void Hit(int dmg)
        {
            Health -= dmg;
            if (Health < 0)
                Health = 0;
            Console.WriteLine("Damage: " + dmg.ToString());
        }
    }
}