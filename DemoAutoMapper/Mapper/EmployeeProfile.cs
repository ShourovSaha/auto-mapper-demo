using AutoMapper;
using DemoAutoMapper.Models;
using DemoAutoMapper.RequestModels;

namespace DemoAutoMapper.Mapper
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeModel>()
                .ForMember(dest => dest.FName, option => option.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LName, option => option.MapFrom(src => src.LastName))
                .ReverseMap();
        }
    }
}
