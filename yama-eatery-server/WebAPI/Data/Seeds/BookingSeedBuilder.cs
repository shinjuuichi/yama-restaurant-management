using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
using WebAPI.Models.Enums;
using WebAPI.Utils;

namespace WebAPI.Data.Seeds
{
    public class BookingSeedBuilder : ISeedBuilder
    {
        public int Priority => 22;

        // Static GUIDs for consistent seeding
        public static readonly Guid[] BookingGuids = new[]
        {
            Guid.Parse("10000000-0000-0000-0000-000000000001"),
            Guid.Parse("10000000-0000-0000-0000-000000000002"),
            Guid.Parse("10000000-0000-0000-0000-000000000003"),
            Guid.Parse("10000000-0000-0000-0000-000000000004"),
            Guid.Parse("10000000-0000-0000-0000-000000000005"),
            Guid.Parse("10000000-0000-0000-0000-000000000006"),
            Guid.Parse("10000000-0000-0000-0000-000000000007"),
            Guid.Parse("10000000-0000-0000-0000-000000000008"),
            Guid.Parse("10000000-0000-0000-0000-000000000009"),
            Guid.Parse("10000000-0000-0000-0000-000000000010")
        };

        public ModelBuilder Seed(ModelBuilder modelBuilder)
        {
            var bookings = new List<object>();
            var dayParts = new[] { DayPartEnum.Morning.ToString(), DayPartEnum.Afternoon.ToString(), DayPartEnum.Evening.ToString() };
            var statuses = new[] { BookingStatusEnum.Booking.ToString(), BookingStatusEnum.Completed.ToString(), BookingStatusEnum.Undeposited.ToString() };

            for (int i = 1; i <= 10; i++)
            {
                var totalPayment = 100.0 + (i * 50);
                var depositPrice = totalPayment * 0.3;

                bookings.Add(new
                {
                    Id = BookingGuids[i - 1],
                    CustomerName = $"Customer {i}",
                    Phone = $"09{i:D8}",
                    Note = $"Booking note {i}",
                    TotalPayment = totalPayment,
                    DepositPrice = depositPrice,
                    RemainPayment = totalPayment - depositPrice,
                    BookingDate = DateOnly.FromDateTime(DateTime.Now.AddDays(i)),
                    DayPart = dayParts[i % 3],
                    BookingStatus = statuses[i % 3],
                    NewPaymentDate = DateTime.Now.AddDays(-i),
                    UserId = i <= 10 ? i : (int?)null,
                    TableId = ((i - 1) % 10) + 1
                });
            }

            modelBuilder.Entity<Booking>().HasData(bookings.ToArray());
            return modelBuilder;
        }
    }
}
