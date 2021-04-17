using NUnit.Framework;

namespace Robots.Tests
{
    using System;

    public class RobotsTests
    {
        private Robot robot;
        private RobotManager robotManager;

        [SetUp]
        public void SetUp()
        {
            robot = new Robot("test", 10);
            robotManager = new RobotManager(10);
        }

        [Test]
        public void WhenRobotIsCreate_PropertiesShouldBeSet()
        {
            Assert.AreEqual("test", robot.Name);
            Assert.AreEqual(10, robot.Battery);
            Assert.AreEqual(10, robot.MaximumBattery);
        }

        [Test]
        public void WhenRobotManagerIsCreate_CapacityShouldBeSet()
        {
            Assert.AreEqual(10, robotManager.Capacity);
        }

        [Test]
        public void WhenRobotManagerIsCapacityIsNegative_ExceptionShouldBeThrow()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                RobotManager robo = new RobotManager(-5);
            });
        }

        [Test]
        public void WhenRobotManagerIsCreate_CountShouldBe0()
        {
            Assert.AreEqual(0, robotManager.Count);
        }

        [Test]
        public void WhenAddSameRobots_ExceptionShouldBeThrow()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                robotManager.Add(robot);
                robotManager.Add(robot);
            });
        }

        [Test]
        public void WhenAddWithoutCapacity_ExceptionShouldBeThrow()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                RobotManager robots = new RobotManager(1);
                robotManager.Add(robot);
                robotManager.Add(robot);
            });

            Assert.Throws<InvalidOperationException>(() =>
            {
                RobotManager robo = new RobotManager(0);
                robotManager.Add(robot);
            });
        }

        [Test]
        public void WhenAddWithCorrectData_ShouldWork()
        {
            robotManager.Add(robot);
            Assert.AreEqual(1, robotManager.Count);
            robotManager.Add(new Robot("Test2", 20));
            Assert.AreEqual(2, robotManager.Count);

        }

        [Test]
        public void WhenRemoveNotExistingRobot_ExceptionShouldBeThrow()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                robotManager.Remove("nqma me");
            });
        }

        [Test]
        public void WhenRemoveNotExistingRobot_ShouldRemoveCorrected()
        {

            robotManager.Add(new Robot("ima me", 2));
            robotManager.Remove("ima me");
            Assert.AreEqual(0, robotManager.Count);

        }

        [Test]
        public void WhenWorkNotExistingRobot_ExceptionShouldBeThrow()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                robotManager.Work("nqma me", "", 10);
            });
        }

        [Test]
        public void WhenWorkNotChargedRobot_ExceptionShouldBeThrow()
        {
            robotManager.Add(robot);

            Assert.Throws<InvalidOperationException>(() =>
            {
                robotManager.Work(robot.Name, "Job", 100);
            });
        }

        [Test]
        public void WhenWorkChargedRobot_ShouldDecreaseBattery()
        {
            robotManager.Add(robot);
            robotManager.Work(robot.Name, "job", 5);
            Assert.AreEqual(robot.Battery, 5);
        }

        [Test]
        public void WhenChargeNotChargedRobot_ExceptionShouldBeThrow()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {

                robotManager.Charge("nqmam me");
            });
        }

        [Test]
        public void WhenChargedRobot_ShouldGetBatteryToMaximum()
        {
            robotManager.Add(robot);
            robotManager.Work(robot.Name, "job", 5);
            robotManager.Charge(robot.Name);
            Assert.AreEqual(robot.Battery, 10);
        }
    }
}
