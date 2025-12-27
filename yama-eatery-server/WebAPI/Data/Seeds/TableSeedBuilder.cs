using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
using WebAPI.Models.Enums;
using WebAPI.Utils;

namespace WebAPI.Data.Seeds
{
    public class TableSeedBuilder : ISeedBuilder
    {
        public int Priority => 8;

        public ModelBuilder Seed(ModelBuilder modelBuilder)
        {
            var tables = new List<object>();
            var types = new[] { TypeEnum.Small.ToString(), TypeEnum.Big.ToString(), TypeEnum.Round.ToString(), TypeEnum.Private.ToString() };

            for (int i = 1; i <= 10; i++)
            {
                tables.Add(new
                {
                    Id = i,
                    Floor = (i - 1) / 3 + 1, // Floor 1-4
                    Type = types[(i - 1) % 4],
                    Image = new List<string> { $"https://via.placeholder.com/300?text=Table+{i}" },
                    CreationDate = DateTime.Now.AddDays(-i * 5),
                    ModificationDate = (DateTime?)DateTime.Now.AddDays(-i * 2),
                    DeletionDate = (DateTime?)null,
                    IsDeleted = false
                });
            }

            modelBuilder.Entity<Table>().HasData(tables.ToArray());
            return modelBuilder;
        }
    }
}
