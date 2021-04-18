using System.Collections.Generic;
using System.Linq;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Peripherals;

namespace OnlineShop.Models.Products.Computers
{
    public abstract class Computer : Product, IComputer
    {
        private readonly IDictionary<string, IComponent> components;
        private readonly IDictionary<string, IPeripheral> peripherals;

        protected Computer(int id, string manufacturer, string model, decimal price, 
            double overallPerformance) 
            : base(id, manufacturer, model, price, overallPerformance)
        {
            this.components = new Dictionary<string, IComponent>();
        }

        public IReadOnlyCollection<IComponent> Components => this.components.Values.ToList();

        public IReadOnlyCollection<IPeripheral> Peripherals => this.peripherals.Values.ToList();

        public void AddComponent(IComponent component)
        {
            throw new System.NotImplementedException();
        }

        public IComponent RemoveComponent(string componentType)
        {
            throw new System.NotImplementedException();
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            throw new System.NotImplementedException();
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            throw new System.NotImplementedException();
        }
    }
}