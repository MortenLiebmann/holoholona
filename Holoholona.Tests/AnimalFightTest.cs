using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Holoholona.Web.Models;

namespace Holoholona.Tests
{
    [TestClass]
    public class AnimalFightTest
    {
        [TestMethod]
        public void AttackAndHitTest()
        {
            Animal a1 = new Animal() { Id = Guid.NewGuid(), Level = 5, Strength = 40, Speed = 100, Defence = 200, Name = "Dog" };
            Animal a2 = new Animal() { Id = Guid.NewGuid(), Level = 100, Health = 200, Strength = 219, Speed = 100, Defence = 36, Name = "Cat" };
            Attack attack = new Attack() { Damage = 80, Accuracy = 100, CriticalHitChance = 10 };

            var result = a1.Attack(attack, a2);

            Assert.IsTrue(result >= 0);
        }
    }
}
