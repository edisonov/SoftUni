namespace OnlineShop.Models.Products.Components
{
    public class PowerSupply : Component
    {
        private const double overallPerformance = 1.05;

        public PowerSupply(int id, string manufacturer, string model,
            decimal price, int generation)
            : base(id, manufacturer, model, price, overallPerformance, generation)
        {
        }
    }
}