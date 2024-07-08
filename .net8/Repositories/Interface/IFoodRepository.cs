using Repositories.DataModels;

namespace Repositories.Interface
{
    public interface IFoodRepository : IGenericRepository<FoodList> 
    {
        int CountFoodList(string? searchElement, int foodType);

        List<FoodList> GetFoodLists(string? searchElement, bool lowToHigh, int foodType, int skip, int pageSize);
    }
}