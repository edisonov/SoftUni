using System;
using WarCroft.Entities.Inventory;

namespace WarCroft.Entities.Characters.Contracts
{
    public class Priest : IHealer
    {
        private double BaseHealth = 50;
        private double BaseArmor = 25;
        private double AbilityPoints = 40;
        private IBag bag = new Backpack();

        public Priest(string name)
        {
            this.Name = name;
            this.bag = new Backpack();
        }
        public string Name { get; set; }

       
        public void Heal(Character character)
        {
            if (character.IsAlive)
            {
                character.Health += AbilityPoints;
            }
        }
    }
}