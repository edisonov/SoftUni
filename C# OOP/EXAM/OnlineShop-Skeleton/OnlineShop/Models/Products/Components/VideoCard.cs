namespace OnlineShop.Models.Products.Components
{
    public class VideoCard : Component
    {
        private const double overallPerformance = 1.15;

        public VideoCard(int id, string manufacturer, string model,
            decimal price, int generation)
            : base(id, manufacturer, model, price, overallPerformance, generation)
        {
        }
    }
}