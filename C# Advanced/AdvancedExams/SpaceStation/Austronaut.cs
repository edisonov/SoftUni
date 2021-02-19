﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation
{
    public class Austronaut
    {
        public Austronaut(string name, int age, string country)
        {
            Name = name;
            Age = age;
            Country = country;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Country { get; set; }

        public override string ToString()
        {
            return $"Austronaut: {Name}, {Age} ({Country})";
        }
    }
}
