﻿using System;
using System.Collections.Generic;
using System.Linq;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Repositories.Contracts;
using EasterRaces.Utilities.Messages;

namespace EasterRaces.Repositories.Entities
{
    public class RaceRepository : IRepository<IRace>
    {
        private readonly IDictionary<string, IRace> raceByName;

        public RaceRepository()
        {
            this.raceByName = new Dictionary<string, IRace>();
        }

        public IRace GetByName(string name)
        {
            IRace race = null;

            if (this.raceByName.ContainsKey(name))
            {
                race = raceByName[name];
            }

            return race;
        }

        public IReadOnlyCollection<IRace> GetAll()
        {
            return this.raceByName.Values.ToList();
        }

        public void Add(IRace model)
        {
            if (this.raceByName.ContainsKey(model.Name))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceExists, model.Name));
            }

            this.raceByName.Add(model.Name, model);
        }

        public bool Remove(IRace model)
        {
            return this.raceByName.Remove(model.Name);
        }
    }
}