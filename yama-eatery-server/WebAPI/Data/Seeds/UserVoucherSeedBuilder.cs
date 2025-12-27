using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
using WebAPI.Utils;

namespace WebAPI.Data.Seeds
{
    public class UserVoucherSeedBuilder : ISeedBuilder
    {
        public int Priority => 21;

        public ModelBuilder Seed(ModelBuilder modelBuilder)
        {
            var userVouchers = new List<object>();

            for (int i = 1; i <= 10; i++)
            {
                userVouchers.Add(new
                {
                    UserId = i,
                    VoucherId = ((i - 1) % 10) + 1,
                    IsUsed = i % 3 == 0
                });
            }

            modelBuilder.Entity<UserVoucher>().HasData(userVouchers.ToArray());
            return modelBuilder;
        }
    }
}
