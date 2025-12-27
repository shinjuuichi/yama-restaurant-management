using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
using WebAPI.Models.Enums;
using WebAPI.Utils;

namespace WebAPI.Data.Seeds
{
    public class MembershipSeedBuilder : ISeedBuilder
    {
        public int Priority => 7;

        public ModelBuilder Seed(ModelBuilder modelBuilder)
        {
            var memberships = new List<object>();

            for (int i = 1; i <= 10; i++)
            {
                var statuses = new[] {
                    MembershipStatusEnum.Active.ToString(),
                    MembershipStatusEnum.Requesting.ToString(),
                    MembershipStatusEnum.Inactive.ToString()
                };
                var ranks = new[] {
                    RankEnum.Member.ToString(),
                    RankEnum.Silver.ToString(),
                    RankEnum.Gold.ToString(),
                    RankEnum.Platinum.ToString()
                };

                memberships.Add(new
                {
                    Id = i,
                    MembershipStatus = statuses[i % 3],
                    Rank = ranks[i % 4],
                    MemberScore = i * 100
                });
            }

            modelBuilder.Entity<Membership>().HasData(memberships.ToArray());
            return modelBuilder;
        }
    }
}
