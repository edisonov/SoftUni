namespace OnlineShop.Models.Products.Components
{
    public class RandomAccessMemory : Component
    {
        private const double overallPerformance = 1.20;

        public RandomAccessMemory(int id, string manufacturer, string model,
            decimal price, int generation)
            : base(id, manufacturer, model, price, overallPerformance, generation)
        {
        }
    }
}