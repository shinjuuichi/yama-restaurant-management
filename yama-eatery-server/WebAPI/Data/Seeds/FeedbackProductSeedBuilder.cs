using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
using WebAPI.Utils;

namespace WebAPI.Data.Seeds
{
    public class FeedbackProductSeedBuilder : ISeedBuilder
    {
        public int Priority => 25;

        public ModelBuilder Seed(ModelBuilder modelBuilder)
        {
            var feedbacks = new List<object>();

            for (int i = 1; i <= 10; i++)
            {
                feedbacks.Add(new
                {
                    UserId = ((i - 1) % 10) + 1,  // User 1-10
                    ProductId = i,  // Product 1-10
                    Rating = (double)(3 + (i % 3)), // Rating 3-5
                    Message = $"Great product! I really enjoyed this item. Would definitely order again.",
                    CreationDate = DateTime.Now.AddDays(-i * 3),
                    ModificationDate = (DateTime?)null
                });
            }

            modelBuilder.Entity<FeedbackProduct>().HasData(feedbacks.ToArray());
            return modelBuilder;
        }
    }
}
