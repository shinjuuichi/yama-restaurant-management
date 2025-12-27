using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
using WebAPI.Models.Enums;
using WebAPI.Utils;

namespace WebAPI.Data.Seeds
{
    public class BookingDetailSeedBuilder : ISeedBuilder
    {
        public int Priority => 23;

        public ModelBuilder Seed(ModelBuilder modelBuilder)
        {
            var bookingDetails = new List<object>();
            var cookingStatuses = new[] {
                CookingStatusEnum.InCooking.ToString(),
                CookingStatusEnum.Cooked.ToString(),
                CookingStatusEnum.InTrouble.ToString()
            };

            for (int i = 1; i <= 10; i++)
            {
                bookingDetails.Add(new
                {
                    Id = i,
                    BookingId = BookingSeedBuilder.BookingGuids[i - 1],
                    ProductId = ((i - 1) % 10) + 1,
                    CookingStatus = cookingStatuses[i % 3],
                    Quantity = 1 + (i % 5),
                    UnitPrice = 10.0 + (i * 5.0)
                });
            }

            modelBuilder.Entity<BookingDetail>().HasData(bookingDetails.ToArray());
            return modelBuilder;
        }
    }
}
