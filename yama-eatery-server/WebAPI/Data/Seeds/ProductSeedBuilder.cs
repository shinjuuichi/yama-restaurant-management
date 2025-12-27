using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
using WebAPI.Utils;

namespace WebAPI.Data.Seeds
{
    public class ProductSeedBuilder : ISeedBuilder
    {
        public int Priority => 15;

        public ModelBuilder Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new
                {
                    Id = 1,
                    Name = "Spring Rolls",
                    Price = 8.99,
                    Description = "Crispy Vietnamese spring rolls with fresh vegetables",
                    StockQuantity = 50,
                    SubCategoryId = 1,
                    Image = new List<string> { "https://via.placeholder.com/300?text=Spring+Rolls" },
                    CreationDate = DateTime.Now.AddDays(-30),
                    ModificationDate = DateTime.Now.AddDays(-30),
                    IsDeleted = false
                },
                new
                {
                    Id = 2,
                    Name = "Pho Bo",
                    Price = 12.99,
                    Description = "Traditional Vietnamese beef noodle soup",
                    StockQuantity = 100,
                    SubCategoryId = 3,
                    Image = new List<string> { "https://via.placeholder.com/300?text=Pho+Bo" },
                    CreationDate = DateTime.Now.AddDays(-28),
                    ModificationDate = DateTime.Now.AddDays(-28),
                    IsDeleted = false
                },
                new
                {
                    Id = 3,
                    Name = "Mango Sticky Rice",
                    Price = 6.99,
                    Description = "Sweet mango with sticky rice and coconut milk",
                    StockQuantity = 30,
                    SubCategoryId = 9,
                    Image = new List<string> { "https://via.placeholder.com/300?text=Mango+Rice" },
                    CreationDate = DateTime.Now.AddDays(-25),
                    ModificationDate = DateTime.Now.AddDays(-25),
                    IsDeleted = false
                },
                new
                {
                    Id = 4,
                    Name = "Fresh Garden Salad",
                    Price = 7.50,
                    Description = "Mixed greens with house dressing",
                    StockQuantity = 40,
                    SubCategoryId = 2,
                    Image = new List<string> { "https://via.placeholder.com/300?text=Salad" },
                    CreationDate = DateTime.Now.AddDays(-20),
                    ModificationDate = DateTime.Now.AddDays(-20),
                    IsDeleted = false
                },
                new
                {
                    Id = 5,
                    Name = "Tom Yum Soup",
                    Price = 9.99,
                    Description = "Spicy and sour Thai soup with shrimp",
                    StockQuantity = 60,
                    SubCategoryId = 1,
                    Image = new List<string> { "https://via.placeholder.com/300?text=Tom+Yum" },
                    CreationDate = DateTime.Now.AddDays(-18),
                    ModificationDate = DateTime.Now.AddDays(-18),
                    IsDeleted = false
                },
                new
                {
                    Id = 6,
                    Name = "Coca Cola",
                    Price = 2.50,
                    Description = "Classic Coca Cola soft drink",
                    StockQuantity = 200,
                    SubCategoryId = 6,
                    Image = new List<string> { "https://via.placeholder.com/300?text=Coca+Cola" },
                    CreationDate = DateTime.Now.AddDays(-15),
                    ModificationDate = DateTime.Now.AddDays(-15),
                    IsDeleted = false
                },
                new
                {
                    Id = 7,
                    Name = "Red Wine",
                    Price = 35.00,
                    Description = "Premium red wine selection",
                    StockQuantity = 25,
                    SubCategoryId = 7,
                    Image = new List<string> { "https://via.placeholder.com/300?text=Red+Wine" },
                    CreationDate = DateTime.Now.AddDays(-12),
                    ModificationDate = DateTime.Now.AddDays(-12),
                    IsDeleted = false
                },
                new
                {
                    Id = 8,
                    Name = "Vietnamese Coffee",
                    Price = 4.50,
                    Description = "Strong Vietnamese drip coffee with condensed milk",
                    StockQuantity = 80,
                    SubCategoryId = 8,
                    Image = new List<string> { "https://via.placeholder.com/300?text=Vietnamese+Coffee" },
                    CreationDate = DateTime.Now.AddDays(-10),
                    ModificationDate = DateTime.Now.AddDays(-10),
                    IsDeleted = false
                },
                new
                {
                    Id = 9,
                    Name = "Orange Juice",
                    Price = 5.00,
                    Description = "Freshly squeezed orange juice",
                    StockQuantity = 70,
                    SubCategoryId = 6,
                    Image = new List<string> { "https://via.placeholder.com/300?text=Orange+Juice" },
                    CreationDate = DateTime.Now.AddDays(-8),
                    ModificationDate = DateTime.Now.AddDays(-8),
                    IsDeleted = false
                },
                new
                {
                    Id = 10,
                    Name = "Mango Smoothie",
                    Price = 6.50,
                    Description = "Creamy mango smoothie with yogurt",
                    StockQuantity = 55,
                    SubCategoryId = 10,
                    Image = new List<string> { "https://via.placeholder.com/300?text=Mango+Smoothie" },
                    CreationDate = DateTime.Now.AddDays(-5),
                    ModificationDate = DateTime.Now.AddDays(-5),
                    IsDeleted = false
                }
            );

            return modelBuilder;
        }
    }
}
