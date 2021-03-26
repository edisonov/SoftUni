using ExtendedDatabase;
using System;
using NUnit.Framework;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase.ExtendedDatabase extendedDatabase;

        [SetUp]
        public void Setup()
        {
            this.extendedDatabase = new ExtendedDatabase.ExtendedDatabase();
        }

        [Test]
        public void Add_ThrowsException_WhenCapacityIsExeeded()
        {
            for (int i = 0; i < 16; i++)
            {
                this.extendedDatabase.Add(new Person(i, $"Username{i}"));
            }

            Assert.Throws<InvalidOperationException>(() =>
               this.extendedDatabase.Add(new Person(16, "InvalidUsername")));
        }

        [Test]
        public void Add_ThrowsException_WhenUsernameIsUsed()
        {
            string username = "Nasko";
            this.extendedDatabase.Add(new Person(1, username));

            Assert.Throws<InvalidOperationException>(() =>
               this.extendedDatabase.Add(new Person(2, username)));
        }


        [Test]
        public void Add_ThrowsException_WhenIdIsUsed()
        {
            long id = 1;
            
            this.extendedDatabase.Add(new Person(id, "RandomUser"));

            Assert.Throws<InvalidOperationException>(() =>
               this.extendedDatabase.Add(new Person(id, "RandomUser2")));
        }


        [Test]
        public void Add_IncreasesCounter_WhenUserIsValid()
        {
            this.extendedDatabase.Add(new Person(1, "Nasko"));
            this.extendedDatabase.Add(new Person(2, "Stoyan"));

            int expectedCount = 2;

            Assert.That(this.extendedDatabase.Count, Is.EqualTo(expectedCount));
        }

        [Test]
        public void Remove_ThrowsException_WhenDatabaseIsEmpty()
        {
            Assert.Throws<InvalidOperationException>(() => this.extendedDatabase.Remove());
        }

        [Test]
        public void Remove_RemovesElementFromDatabase()
        {
            int n = 5;

            for (int i = 0; i < n; i++)
            {
                this.extendedDatabase.Add(new Person(i, $"Username{i}"));
            }

            this.extendedDatabase.Remove();

            Assert.That(this.extendedDatabase.Count, Is.EqualTo(n - 1));
            Assert.Throws<InvalidOperationException>(() => this.extendedDatabase.FindById(n - 1));
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void FindByUsername_ThrowException_WhenArgumentIsNotValid(string name)
        {
            Assert.Throws<ArgumentNullException>(() => this.extendedDatabase.FindByUsername(name));
        }

        [Test]
        
        public void FindByUsername_ThrowException_WhenUsernameDoesNotExist()
        {
            Assert.Throws<InvalidOperationException>(() => this.extendedDatabase.FindByUsername("Username"));
        }

        [Test]
        public void FindByUsername_ReturnsExpectedUser_WhenUserExists()
        {
            Person person = new Person(1, "Nasko");

            this.extendedDatabase.Add(person);

            Person dbPerson = this.extendedDatabase.FindByUsername(person.UserName);

            Assert.That(person, Is.EqualTo(dbPerson));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(-25)]
        public void FindById_ThrowsException_WhenIdIsLessThanZero(long id)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => this.extendedDatabase.FindById(id));
        }

        [Test]
        public void FindById_ThrowsException_WhenUserWithIdDoesNotExist()
        {
            Assert.Throws<InvalidOperationException>(() => this.extendedDatabase.FindById(100));
        }

        [Test]
        public void FindById_ReturnsExpectedUser_WhenUserExists()
        {
            Person person = new Person(1, "Nasko");

            this.extendedDatabase.Add(person);

            Person dbPerson = this.extendedDatabase.FindById(person.Id);

            Assert.That(person, Is.EqualTo(dbPerson));
        }

        [Test]
        public void Ctor_ThrowException_WhenCapacityIsExceeded()
        {
            Person[] arguments = new Person[17];

            for (int i = 0; i < arguments.Length; i++)
            {
                arguments[i] = new Person(i, $"Username{i}");
            }

            Assert.Throws<ArgumentException>(() =>
            this.extendedDatabase = new ExtendedDatabase.ExtendedDatabase(arguments));
        }

        [Test]
        public void Ctor_AddInitialPeopleToDatabase()
        {
            Person[] arguments = new Person[5];

            for (int i = 0; i < arguments.Length; i++)
            {
                arguments[i] = new Person(i, $"Username{i}");
            }

            this.extendedDatabase = new ExtendedDatabase.ExtendedDatabase(arguments);

            Assert.That(this.extendedDatabase.Count, Is.EqualTo(arguments));

            foreach (var person in arguments)
            {
                Person dbPerson = this.extendedDatabase.FindById(person.Id);

                Assert.That(person, Is.EqualTo(dbPerson));
            }
        }


    }
}