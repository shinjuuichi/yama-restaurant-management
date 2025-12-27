using Microsoft.EntityFrameworkCore;

namespace WebAPI.Utils
{
    public interface ISeedBuilder
    {
        int Priority { get; }
        ModelBuilder Seed(ModelBuilder modelBuilder);
    }
}
