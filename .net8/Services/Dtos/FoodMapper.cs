using Repositories.DataModels;

namespace Services.Dtos;
public static class FoodMapper
{
    public static FoodDto ToDto(this FoodList foodList)
    {
        return new FoodDto
        {
            Name = foodList.Name,
            FoodId = foodList.FoodId,
            Price = foodList.Price,
            IsVeg = foodList.IsVeg,
        };
    }
}
