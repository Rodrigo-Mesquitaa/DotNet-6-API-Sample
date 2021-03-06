using API_Sample_DotNet_6.Entities;
using API_Sample_DotNet_6.Repositories;
using System;

using System.Threading.Tasks;

namespace API_Sample_DotNet_6.Services
{
    public class SeedDataService : ISeedDataService
    {
        public async Task Initialize(FoodDbContext context)
        {
            context.FoodItems.Add(new FoodEntity() { Calories = 1000, Type = "Starter", Name = "Lasagne", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { Calories = 1100, Type = "Main", Name = "Hamburger", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { Calories = 1200, Type = "Dessert", Name = "Spaghetti", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { Calories = 1300, Type = "Starter", Name = "Pizza", Created = DateTime.Now });

            await context.SaveChangesAsync();
        }
    }
}
