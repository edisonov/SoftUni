using System.Numerics;
using NUnit.Framework;

namespace Aquariums.Tests
{
    using System;

    public class AquariumsTests
    {
        private Aquarium aquarium;
        private Fish fish;
        [SetUp]
        public void Setup()
        {
            aquarium = new Aquarium("Pz", 100);
            fish = new Fish("Boko");
        }

        [Test]
        public void Ctor_ThrowName()
        {
            Assert.Throws<ArgumentNullException>(() =>
                aquarium = new Aquarium("", 100));
            Assert.Throws<ArgumentNullException>(() =>
                aquarium = new Aquarium(null, 100));
        }

        [Test]
        public void Ctor_ThrowCapacity()
        {
            Assert.Throws<ArgumentException>(() =>
                aquarium = new Aquarium("Pz", -1));
            Assert.Throws<ArgumentException>(() =>
                aquarium = new Aquarium("Pz", -21));
        }

        [Test]
        public void Ctor_Work()
        {
            Assert.AreEqual(aquarium.Name, "Pz");
            Assert.AreEqual(aquarium.Capacity, 100);
        }

        [Test]
        public void Ctor_WorkCount()
        {
            Assert.That(aquarium.Count, Is.Not.Null);
        }
        [Test]
        public void Fish_Work()
        {
            Assert.AreEqual(fish.Name, "Boko");
            Assert.IsTrue(fish.Available);
        }

        [Test]
        public void AddFish_Throw()
        {
            aquarium = new Aquarium("Pz", 1);
            aquarium.Add(fish);

            Assert.AreEqual(aquarium.Count, 1);
        }

        [Test]
        public void RemoveFish_Throw()
        {
            aquarium = new Aquarium("Pz", 4);
            aquarium.Add(fish);

            Assert.Throws<InvalidOperationException>(() => aquarium.RemoveFish("Kiro"));
        }

        [Test]
        public void RemoveFish_Work()
        {
            aquarium = new Aquarium("Pz", 2);
            aquarium.Add(fish);
            aquarium.RemoveFish("Boko");

            Assert.AreEqual(aquarium.Count, 0);
        }

        [Test]
        public void SellFish_Throw()
        {
            aquarium = new Aquarium("Pz", 4);
            aquarium.Add(fish);
            aquarium.SellFish("Boko");

            Assert.IsFalse(fish.Available);
        }

        [Test]
        public void SeelFish_WorkReturn()
        {
            aquarium = new Aquarium("Pz", 2);
            aquarium.Add(fish);

            string text = aquarium.Report();

            Assert.AreEqual($"Fish available at {aquarium.Name}: Boko", text);
        }
    }
}
