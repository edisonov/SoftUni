using System;
using System.Collections.Generic;
using System.Linq;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Repositories.Contracts;
using EasterRaces.Utilities.Messages;

namespace EasterRaces.Repositories.Entities
{
    public class DriverRepository : IRepository<IDriver>
    {
        private readonly IDictionary<string, IDriver> driversByName;

        public DriverRepository()
        {
            this.driversByName = new Dictionary<string, IDriver>();
        }

        public IDriver GetByName(string name)
        {
            IDriver driver = null;

            if (this.driversByName.ContainsKey(name))
            {
                driver = driversByName[name];
            }

            return driver;
        }

        public IReadOnlyCollection<IDriver> GetAll()
        {
            return this.driversByName.Values.ToList();
        }

        public void Add(IDriver model)
        {
            if (this.driversByName.ContainsKey(model.Name))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.DriversExists, model.Name));
            }

            this.driversByName.Add(model.Name, model);
        }

        public bool Remove(IDriver model)
        {
            return this.driversByName.Remove(model.Name);
        }
    }
}