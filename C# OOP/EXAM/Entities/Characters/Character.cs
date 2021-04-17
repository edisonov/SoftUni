using System;

using WarCroft.Constants;
using WarCroft.Entities.Inventory;

namespace WarCroft.Entities.Characters.Contracts
{
    public abstract class Character
    {
        private string name;
        private double health;
        private double armor;

        protected Character(string name, double health, double armor, double abilityPoints, Bag bag)
        {
            this.Name = name;
            this.Health = health;
            this.Armor = armor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace!");
                }

                this.name = value;
            }
        }

        public double BaseHealth { get; set; }

        public double Health
        {
            get => this.health;
            set
            {
                if (value < BaseHealth || value > 0)
                {
                    this.health = value;
                }
            }
        }

        public double BaseArmor { get; set; }

        public double Armor
        {
            get => this.armor;
            set
            {
                if (value > 0)
                {
                    this.armor = value;
                }
            }
        }

        public double AbilityPoints  { get; set; }

        public Bag Bag { get; set; }

		public bool IsAlive { get; set; } = true;

        public void TakeDamage(double hitPoints)
        {
            if (IsAlive)
            {
                if (armor - hitPoints >= 0)
                {
                     this.armor -= hitPoints;
                     return;
                }
                else if (armor > 0)
                {
                    hitPoints -= armor;
                    armor = 0;
                }

                Health -= hitPoints;
            }
            
        }

        protected void EnsureAlive()
		{
			if (!this.IsAlive)
			{
				throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
			}
		}
	}
}