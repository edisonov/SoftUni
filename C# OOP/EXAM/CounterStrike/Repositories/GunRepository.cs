using System;
using System.Collections.Generic;
using System.Linq;
using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Repositories.Contracts;

namespace CounterStrike.Repositories
{
    public class GunRepository : IRepository<IGun>
    {
        private List<IGun> models;

        public GunRepository()
        {
            this.models = new List<IGun>();
        }

        public IReadOnlyCollection<IGun> Models => this.models.AsReadOnly();

        public void Add(IGun model)
        {
            if (model == null)
            {
                throw new ArgumentException("Cannot add null in Gun Repository");
            }

            this.models.Add(model);
        }

        public bool Remove(IGun model)
        {
           return this.models.Remove(model);
        }

        public IGun FindByName(string name)
        {
            var result = this.models.FirstOrDefault(x => x.Name == name);

            return result;
        }
    }
}