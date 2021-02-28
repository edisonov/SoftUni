using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Child : Person
    {
        private List<Person> data;

        public Child(string name, int age)
            :base(name, age)
        { 
            data = new List<Person>();
        }

        public void Greater(Person person)
        {
            if (person.Age >= 0 && person.Age <= 15)
            {
                data.Add(person);            
            }
        }
    }
}
