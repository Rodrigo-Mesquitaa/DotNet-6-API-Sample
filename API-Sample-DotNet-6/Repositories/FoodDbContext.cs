using API_Sample_DotNet_6.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_Sample_DotNet_6.Repositories
{
    public class FoodDbContext : DbContext
    {
        public FoodDbContext(DbContextOptions<FoodDbContext> options)
           : base(options)
        {

        }

        public DbSet<FoodEntity> FoodItems { get; set; }

    }
}
