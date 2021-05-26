using API_Sample_DotNet_6.Repositories;
using System.Threading.Tasks;

namespace API_Sample_DotNet_6.Services
{
    public interface ISeedDataService
    {
        Task Initialize(FoodDbContext context);
    }
}
