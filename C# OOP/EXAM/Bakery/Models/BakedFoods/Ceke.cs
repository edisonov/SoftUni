namespace Bakery
{
    public class Ceke : BakedFood
    {
        private const int InitialCakePortion = 245;

        public Ceke(string name, decimal price)
            : base(name, InitialCakePortion, price)
        {
        }
    }
}