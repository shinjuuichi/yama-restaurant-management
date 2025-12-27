using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
using WebAPI.Models.Enums;
using WebAPI.Utils;

namespace WebAPI.Data.Seeds
{
    public class EmployeeSeedBuilder : ISeedBuilder
    {
        public int Priority => 12;

        public ModelBuilder Seed(ModelBuilder modelBuilder)
        {
            var positions = new[] { PositionEnum.Manager, PositionEnum.Staff };

            var employees = new List<object>();
            for (int i = 1; i <= 10; i++)
            {
                var position = positions[(i - 1) % 2];
                employees.Add(new
                {
                    Id = i,
                    Email = $"employee{i}@yama.com",
                    Password = CryptoUtil.EncryptPassword("Password123!"),
                    Name = $"Employee {i}",
                    Image = $"https://via.placeholder.com/150?text=Employee{i}",
                    Birthday = new DateOnly(1985 + i % 15, (i % 12) + 1, (i % 28) + 1),
                    Phone = $"08{i:D8}",
                    Gender = i % 2 == 0 ? "Male" : "Female",
                    PositionId = int.Parse(position.GetEnumDisplayName())
                });
            }

            modelBuilder.Entity<Employee>().HasData(employees.ToArray());
            return modelBuilder;
        }
    }
}
