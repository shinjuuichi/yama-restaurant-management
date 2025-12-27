using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
using WebAPI.Models.Enums;
using WebAPI.Utils;

namespace WebAPI.Data.Seeds
{
    public class SubCategorySeedBuilder : ISeedBuilder
    {
        public int Priority => 5;

        public ModelBuilder Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SubCategory>().HasData(
                // Starters SubCategories (Category 1)
                new { Id = 1, Name = "Spring Rolls", CategoryId = (int)CategoryEnum.Starters },
                new { Id = 2, Name = "Salads", CategoryId = (int)CategoryEnum.Starters },

                // Main SubCategories (Category 2)
                new { Id = 3, Name = "Noodles", CategoryId = (int)CategoryEnum.Main },
                new { Id = 4, Name = "Rice Dishes", CategoryId = (int)CategoryEnum.Main },
                new { Id = 5, Name = "Grilled", CategoryId = (int)CategoryEnum.Main },

                // Beverages SubCategories (Category 3)
                new { Id = 6, Name = "Soft Drinks", CategoryId = (int)CategoryEnum.Beverages },
                new { Id = 7, Name = "Alcoholic", CategoryId = (int)CategoryEnum.Beverages },
                new { Id = 8, Name = "Coffee & Tea", CategoryId = (int)CategoryEnum.Beverages },

                // Desserts SubCategories (Category 4)
                new { Id = 9, Name = "Traditional Desserts", CategoryId = (int)CategoryEnum.Desserts },
                new { Id = 10, Name = "Ice Cream", CategoryId = (int)CategoryEnum.Desserts }
            );

            return modelBuilder;
        }
    }
}
