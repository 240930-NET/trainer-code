using AutoMapper;
using BudgetTracker.API.Models.DTO;
using BudgetTracker.Models;

namespace BudgetTracker.API.Models;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, NewUserDTO>().ReverseMap();
    }
}