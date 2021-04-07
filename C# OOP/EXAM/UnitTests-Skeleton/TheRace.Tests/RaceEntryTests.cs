using System;
using NUnit.Framework;
using TheRace;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        private RaceEntry raceEntry;

        [SetUp]
        public void Setup()
        {
            this.raceEntry = new RaceEntry();
        }

        [Test]
        public void Counter_IsZeroByDefault()
        {
            Assert.AreEqual(this.raceEntry.Counter, 0);
        }

        [Test]
        public void Counter_Increases_WhenAddingDriver()
        {
            this.raceEntry.AddDriver(new UnitDriver("Nasko", new UnitCar("Tesla", 400, 500)));

            Assert.AreEqual(this.raceEntry.Counter, 1);
        }

        [Test]
        public void AddDriver_ThrowsException_WhenDriverIsNull()
        {
            Assert.Throws<InvalidOperationException>(() => this.raceEntry.AddDriver(null));
        }

        [Test]
        public void AddDriver_ThrowException_WhenDriverNameExists()
        {
            var driverName = "Nasko";

            this.raceEntry.AddDriver(new UnitDriver(driverName, new UnitCar("Tesla s", 400, 600)));

            Assert.Throws<InvalidOperationException>(() =>
                this.raceEntry.AddDriver(new UnitDriver(driverName, new UnitCar("Bmw", 299, 400))));
        }

        [Test]
        public void AddDriver_ReturnsExpectedResultMessage()
        {
            var driverName = "Nasko";
            var result = this.raceEntry.AddDriver(new UnitDriver(driverName, new UnitCar("Tesla s", 400, 600)));
            var expected = $"Driver {driverName} added in race.";

            Assert.AreEqual(expected, result);

        }

        [Test]
        public void CalculateAverageHorsePower_ThrowsException_WhenParticipantAreLessThanRequired()
        {
            Assert.Throws<InvalidOperationException>(() => this.raceEntry.CalculateAverageHorsePower());

            this.raceEntry.AddDriver(new UnitDriver("Nasko", new UnitCar("Tesla", 199, 200)));

            Assert.Throws<InvalidOperationException>(() => this.raceEntry.CalculateAverageHorsePower());
        }

        [Test]
        public void CalculateAverageHorsePower_ReturnsExpectedCalculateResult()
        {
            int n = 10;
            double expected = 0;

            for (int i = 0; i < n; i++)
            {
                int hp = 450 + i;
                expected += hp;

                this.raceEntry.AddDriver
                    (new UnitDriver($"Name-{i}", new UnitCar("Model", hp, 550)));
            }

            expected /= n;

            double actual = this.raceEntry.CalculateAverageHorsePower();

            Assert.AreEqual(expected, actual);
        }
    }
}