namespace OnlineShop.Models.Products.Components
{
    public class CentralProcessingUnit : Component
    {
        private double centralProcessingUnit = 1.25;

        public CentralProcessingUnit(int id, string manufacturer, string model,
            decimal price, double overallPerformance, int generation)
            : base(id, manufacturer, model, price, overallPerformance, generation)
        {
            this.overallPerformance *= centralProcessingUnit;
        }
    }
}