﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private List<Racer> data;

        public Race(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Racer>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count { get { return data.Count; } }

        public void Add(Racer Racer)
        {
            if (data.Count < Capacity)
            {
                data.Add(Racer);
            }
        }

        public bool Remove(string name)
        {
            Racer racer = data.FirstOrDefault(x => x.Name == name);

            if (racer == null)
            {
                return false;
            }

            data.Remove(racer);
            return true;
        }

        public Racer GetOldestRacer()
        {
            return data.OrderByDescending(x => x.Age).FirstOrDefault();
        }

        public Racer GetRacer(string name)
        {
            return data.OrderByDescending(x => x.Name == name).FirstOrDefault();
        }

        public Racer GetFastestRacer()
        {
            return data.OrderByDescending(x => x.Car.Speed).FirstOrDefault();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Racers participating at  { this.Name}");

            foreach (var item in data)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();
        }


    }
}
