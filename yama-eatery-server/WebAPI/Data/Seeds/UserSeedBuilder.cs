using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
using WebAPI.Models.Enums;
using WebAPI.Utils;

namespace WebAPI.Data.Seeds
{
    public class UserSeedBuilder : ISeedBuilder
    {
        public int Priority => 10;

        public ModelBuilder Seed(ModelBuilder modelBuilder)
        {
            var users = new List<object>();

            for (int i = 1; i <= 10; i++)
            {
                users.Add(new
                {
                    Id = i,
                    Email = $"user{i}@yama.com",
                    Password = CryptoUtil.EncryptPassword("Password123!"),
                    Name = $"User {i}",
                    Image = $"https://via.placeholder.com/150?text=User{i}",
                    Birthday = new DateOnly(1990 + i % 10, (i % 12) + 1, (i % 28) + 1),
                    Phone = $"09{i:D8}",
                    Gender = i % 2 == 0 ? "Male" : "Female",
                    MembershipId = i,
                    CreationDate = DateTime.Now.AddDays(-i * 10),
                    ModificationDate = (DateTime?)DateTime.Now.AddDays(-i * 5),
                    DeletionDate = (DateTime?)null,
                    IsDeleted = false
                });
            }

            modelBuilder.Entity<User>().HasData(users.ToArray());
            return modelBuilder;
        }
    }
}
