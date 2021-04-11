namespace OnlineShop.Models.Products.Components
{
    public class CentralProcessingUnit : Component
    {
        private const double overallPerformance = 1.25;

        public CentralProcessingUnit(int id, string manufacturer, string model,
            decimal price, int generation)
            : base(id, manufacturer, model, price, overallPerformance, generation)
        {
            
        }
    }
}