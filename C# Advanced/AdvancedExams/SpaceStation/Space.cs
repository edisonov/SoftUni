using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation
{
    public class Space
    {
        private List<Austronaut> austronauts;
        public Space(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            austronauts = new List<Austronaut>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => this.austronauts.Count;

        public void Add(Austronaut austronaut)
        {
            if (this.austronauts.Count < this.Capacity)
            {
                 this.austronauts.Add(austronaut);
            }
        }

        public bool Remove(string name)
        {
            foreach (var item in austronauts)
            {
                if (item.Name == name)
                {
                    this.austronauts.Remove(item);
                    return true;
                }
            }
            return false;
        }

        public Austronaut GetOldestAstronaut()
        {
            Austronaut result = this.austronauts
                .OrderByDescending(x => x.Age)
                .FirstOrDefault();
            return result;
        }

        public Austronaut GetAustronaut(string name)
        {
            return this.austronauts.FirstOrDefault(x => x.Name == name);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Astronoms working at {this.Name}");

            foreach (var item in austronauts)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
