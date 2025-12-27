using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
using WebAPI.Utils;

namespace WebAPI.Data.Seeds
{
    public class VoucherSeedBuilder : ISeedBuilder
    {
        public int Priority => 11;

        public ModelBuilder Seed(ModelBuilder modelBuilder)
        {
            var vouchers = new List<object>();

            for (int i = 1; i <= 10; i++)
            {
                vouchers.Add(new
                {
                    Id = i,
                    Name = $"Voucher {i * 5}% OFF",
                    Description = $"Get {i * 5}% discount on your order up to ${i * 10} max reduction",
                    Image = $"https://via.placeholder.com/300?text=Voucher{i}",
                    ExpiredDate = DateOnly.FromDateTime(DateTime.Now.AddDays(30 + i * 10)),
                    ReducedPercent = i * 5,
                    MaxReducing = i * 10.0,
                    Quantity = 100 - (i * 5),
                    CreationDate = DateTime.Now.AddDays(-i * 3),
                    ModificationDate = (DateTime?)DateTime.Now.AddDays(-i),
                    DeletionDate = (DateTime?)null,
                    IsDeleted = false
                });
            }

            modelBuilder.Entity<Voucher>().HasData(vouchers.ToArray());
            return modelBuilder;
        }
    }
}
