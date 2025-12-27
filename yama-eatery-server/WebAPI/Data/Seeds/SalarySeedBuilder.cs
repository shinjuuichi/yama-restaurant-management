using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
using WebAPI.Utils;

namespace WebAPI.Data.Seeds
{
    public class SalarySeedBuilder : ISeedBuilder
    {
        public int Priority => 18;

        public ModelBuilder Seed(ModelBuilder modelBuilder)
        {
            var salaries = new List<object>();

            for (int i = 1; i <= 10; i++)
            {
                var netSalary = 1000.0 + (i * 200);
                var deductions = netSalary * 0.1;

                salaries.Add(new
                {
                    Id = i,
                    Deductions = deductions,
                    NetSalary = netSalary - deductions,
                    PayDay = i % 2 == 0 ? DateOnly.FromDateTime(DateTime.Now.AddDays(-i * 5)) : (DateOnly?)null,
                    EmployeeId = ((i - 1) % 10) + 1
                });
            }

            modelBuilder.Entity<Salary>().HasData(salaries.ToArray());
            return modelBuilder;
        }
    }
}
