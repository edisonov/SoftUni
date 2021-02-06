using System;
using DefiningClasses;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person personOne = new Person();
            personOne.Name = "Peter";
            personOne.Age = 20;

            Person personTwo = new Person()
            {
                Name = "Kris",
                Age = 22
            };
        }
    }
}
