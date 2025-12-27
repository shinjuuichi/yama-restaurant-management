using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
using WebAPI.Utils;

namespace WebAPI.Data.Seeds
{
    public class ContactSeedBuilder : ISeedBuilder
    {
        public int Priority => 20;

        public ModelBuilder Seed(ModelBuilder modelBuilder)
        {
            var contacts = new List<object>();

            for (int i = 1; i <= 10; i++)
            {
                contacts.Add(new
                {
                    Id = i,
                    FullName = $"Contact User {i}",
                    Title = $"Inquiry {i}: Question about services",
                    Message = $"I have a question about your restaurant services. Can you help me with booking information?",
                    IsIgnored = i % 3 == 0,
                    Respond = i % 2 == 0 ? "Thank you for your inquiry. We will get back to you soon." : (string?)null,
                    CreationDate = DateTime.Now.AddDays(-i * 2),
                    UserId = i <= 10 ? i : (int?)null
                });
            }

            modelBuilder.Entity<Contact>().HasData(contacts.ToArray());
            return modelBuilder;
        }
    }
}
