using System;
using CounterStrike.Models.Guns.Contracts;

namespace CounterStrike.Models.Guns
{
    public abstract class Gun : IGun
    {
        private string name;
        private int bulletsCount;

        protected Gun(string name, int bulletsCount)
        {
            this.Name = name;
            this.BulletsCount = bulletsCount;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Gun cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public int BulletsCount
        {
            get => bulletsCount;
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Bullet cannot be below 0");
                }

                this.bulletsCount = value;
            }
        }

        public abstract int Fire();
    }

}