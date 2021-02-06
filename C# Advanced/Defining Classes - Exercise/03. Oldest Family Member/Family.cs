using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DefiningClasses;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> Members { get; set; }

        public Family()
        {
            this.Members = new List<Person>();
        }

        public void AddMember(Person person)
        {
            this.Members.Add(person);
        }

        public Person GetOldestMember()
        {
            Person person = this.Members
                .OrderByDescending(x => x.Age)
                .FirstOrDefault();
            return person;
        }
    }
}
