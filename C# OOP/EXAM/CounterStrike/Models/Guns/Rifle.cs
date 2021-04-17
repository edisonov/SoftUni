using System;

namespace CounterStrike.Models.Guns
{
    public class Rifle : Gun
    {
        private int fireRate = 10;
        public Rifle(string name, int bulletsCount) : base(name, bulletsCount)
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
                int result = BulletsCount;
                BulletsCount = 0;
                return result;
            }
        }
    }
}