﻿using API_Sample_DotNet_6.Entities;
using API_Sample_DotNet_6.Models;
using System.Collections.Generic;
using System.Linq;


namespace API_Sample_DotNet_6.Repositories
{
    public interface IFoodRepository
    {
        FoodEntity GetSingle(int id);
        void Add(FoodEntity item);
        void Delete(int id);
        FoodEntity Update(int id, FoodEntity item);
        IQueryable<FoodEntity> GetAll(QueryParameters queryParameters);

        ICollection<FoodEntity> GetRandomMeal();
        int Count();

        bool Save();
    }
}
