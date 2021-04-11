using System;
using System.Collections.Generic;
using System.Linq;
using OnlineShop.Common.Constants;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Peripherals;

namespace OnlineShop.Models.Products.Computers
{
    public abstract class Computer : Product, IComputer
    {
        private double overallPerformance;
        private decimal price;

        private readonly List<IComponent> components;
        private readonly List<IPeripheral> peripherals;

        protected Computer(int id, string manufacturer, string model, decimal price, 
            double overallPerformance) 
            : base(id, manufacturer, model, price, overallPerformance)
        {
            this.Price = price;
            this.OverallPerformance = overallPerformance;
            this.components = new List<IComponent>();
        }

        public double OverallPerformance { get; private set; }

        public decimal Price { get; private set; }

        public IReadOnlyCollection<IComponent> Components => this.components.AsReadOnly();

        public IReadOnlyCollection<IPeripheral> Peripherals => this.peripherals.AsReadOnly();

        public void AddComponent(IComponent component)
        {
            if (this.components.Contains(component))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.ExistingComponent, 
                   component.GetType().Name, typeof(Computer), this.Id ));
            }

            this.components.Add(component);
        }

        public IComponent RemoveComponent(string componentType)
        {
            IComponent component = new 

            if (this.components.Any())
            {
                throw new ArgumentException(
                    string.Format(ExceptionMessages.NotExistingComponent,
                        this.components.GetType().Name, typeof(Computer), this.Id));
            }

            this.components.IndexOf(componentType);
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            throw new System.NotImplementedException();
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}