﻿using System;

namespace CounterStrike.Models.Guns
{
    public class Pistol : Gun
    {
        private int fireRate = 1;
        public Pistol(string name, int bulletsCount) : base(name, bulletsCount)
        {
        }

        public override int Fire()
        {
            if (this.BulletsCount - fireRate >= 0)
            {
                return fireRate;
            }
            else
            {
                return 0;
            }
        }
    }
}