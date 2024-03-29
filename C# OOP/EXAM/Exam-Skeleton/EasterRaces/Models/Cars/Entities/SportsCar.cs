﻿namespace EasterRaces.Models.Cars.Entities
{
    public class SportsCar : Car
    {
        private const int DefaultCubicCentimeters = 3000;
        private const int DefaultMinHorsePower = 250;
        private const int DefaultMaxHorsePower = 4500;

        public SportsCar(string model, int horsePower)
            : base(model, horsePower, DefaultCubicCentimeters, DefaultMinHorsePower, DefaultMaxHorsePower)
        {
        }
    }
}