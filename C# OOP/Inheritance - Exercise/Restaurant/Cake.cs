using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        private const decimal DefoultPrice = 5;

        private const double DefoultGrams = 250;

        private const double DefoultCalories = 1000;

        public Cake(string name)
            : base(name, DefoultPrice, DefoultGrams, DefoultCalories)
        {
        }
    }
}
