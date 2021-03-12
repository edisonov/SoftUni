using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals.Mammals.Felines
{
    public abstract class Feline : Mammal
    {

        protected Feline(
            string name, 
            double weight, 
            double weightModifier, 
            HashSet<string> allowedFoods, 
            string livingRegion,
            string breed) 
            : base(name, weight, weightModifier, allowedFoods, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed { get; private set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, " +
                $"{this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
