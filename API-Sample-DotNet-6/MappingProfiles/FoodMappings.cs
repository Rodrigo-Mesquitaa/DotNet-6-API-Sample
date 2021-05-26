using API_Sample_DotNet_6.Dtos;
using API_Sample_DotNet_6.Entities;
using AutoMapper;

namespace API_Sample_DotNet_6.MappingProfiles
{
    public class FoodMappings : Profile
    {
        public FoodMappings()
        {
            CreateMap<FoodEntity, FoodDto>().ReverseMap();
            CreateMap<FoodEntity, FoodUpdateDto>().ReverseMap();
            CreateMap<FoodEntity, FoodCreateDto>().ReverseMap();
        }
    }
}
