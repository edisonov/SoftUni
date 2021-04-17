using System;
using System.Collections.Generic;
using System.Linq;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Inventory
{
    public abstract class Bag : IBag
    {
        private IList<Item> items;

        protected Bag(int capacity)
        {
            this.Capacity = capacity;
            this.items = new List<Item>();
        }

        public int Capacity
        {
            get;
            set;
        }

        public int Load => this.items.Sum(x => x.Weight);

        public IReadOnlyCollection<Item> Items => (IReadOnlyCollection<Item>)items;

        public void AddItem(Item item)
        {
            int sum = this.Load + item.Weight;

            if (sum > this.Capacity)
            {
                throw new InvalidOperationException("Bag is full!");
            }

            items.Add(item);
        }

        public Item GetItem(string name)
        {
            if (this.items.Any())
            {
                throw new InvalidOperationException("Bag is empty!");
            }

            if (items.GetType().Name != name)
            {

                throw new ArgumentException($"No item with name {name} in bag!");
            }

            Item itemsType = items.FirstOrDefault(x => x.GetType().Name == name);
            this.items.Remove(itemsType);
            return itemsType;
        }
    }
}