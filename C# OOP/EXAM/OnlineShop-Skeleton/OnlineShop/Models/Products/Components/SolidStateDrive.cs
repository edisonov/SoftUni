namespace OnlineShop.Models.Products.Components
{
    public class SolidStateDrive : Component
    {
        private const double overallPerformance = 1.20;

        public SolidStateDrive(int id, string manufacturer, string model,
            decimal price, int generation)
            : base(id, manufacturer, model, price, overallPerformance, generation)
        {
        }
    }
}