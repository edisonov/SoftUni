using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals.Mammals
{
    class Dog : Mammal
    {
        private const double BaseWeightModifier = 0.4;

        private static HashSet<string> allowedFoods = new HashSet<string>
        {
            nameof(Meat)
        };

        public Dog(
            string name,
            double weight,
            string livingRegion)
            : base(name, weight, BaseWeightModifier, allowedFoods, livingRegion)
        {
        }

        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}
