using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        private readonly List<IComputer> computers;

        protected Computer(int id, string manufacturer, string model,
            decimal price, double overallPerformance) 
            : base(id, manufacturer, model, price, overallPerformance)
        {
            this.OverallPerformance = overallPerformance;
            components = new List<IComponent>();
            peripherals = new List<IPeripheral>();
            computers = new List<IComputer>();
        }

        public double OverallPerformance
        {
            get => this.overallPerformance;
            private set
            {
                if (components.Any())
                {
                    value = computers.Sum(x => x.OverallPerformance);
                }

                overallPerformance = value;
            }
        }

        public decimal Price
        {
            get => this.price;
            private set
            {

            }
        }

        public IReadOnlyCollection<IComponent> Components => this.components.AsReadOnly();

        public IReadOnlyCollection<IPeripheral> Peripherals => this.peripherals.AsReadOnly();

        public void AddComponent(IComponent component)
        {
            if (components.Contains(component))
            {
                throw new ArgumentException(
                    $"Component {component.GetType().Name} " +
                    $"already exists in {computers.GetType().Name} with Id {Id}.)");
            }

            components.Add(component);
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Overall Performance: {OverallPerformance}." +
                          $" Price: {Price} - {this.GetType().Name}: {Manufacturer} {Model}"+
                $" (Id: {Id})");
            sb.AppendLine($"Components ({components.Count}):");
            sb.AppendLine("{component one}");
            sb.AppendLine("{component two}");
            sb.AppendLine("{component n}");
            sb.AppendLine($" Peripherals ({peripherals}); Average Overall Performance" +
                          $" ({ peripherals}):");
            sb.AppendLine("{peripheral one}");
            sb.AppendLine("{peripheral two}");
            sb.AppendLine("{peripheral n}");

            return sb.ToString().TrimEnd();
        }
    }
}