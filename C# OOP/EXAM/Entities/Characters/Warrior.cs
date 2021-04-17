using System;
using WarCroft.Entities.Inventory;

namespace WarCroft.Entities.Characters.Contracts
{
    public class Warrior : IAttacker
    {
        private double BaseHealth = 100;
        private double BaseArmor = 50;
        private double AbilityPoints = 50;
        private IBag bag = new Satchel();

        public Warrior(string name)
        {
            this.Name = name;
            this.bag = new Satchel();
        }
        public string Name { get; set; }

        public void Attack(Character character)
        {
            if (character.IsAlive)
            {
                
            }
        }
    }
}