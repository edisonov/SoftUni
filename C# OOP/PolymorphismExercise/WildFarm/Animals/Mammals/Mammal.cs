using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals.Mammals
{
    public abstract class Mammal : Animal
    {
        public Mammal(
            string name, 
            double weight,  
            double weightModifier, 
            HashSet<string> allowedFoods, string livingRegion) 
            : base(name, weight, weightModifier, allowedFoods)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion { get; private set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
