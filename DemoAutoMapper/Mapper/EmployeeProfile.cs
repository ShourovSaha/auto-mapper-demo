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
                .ReverseMap();
        }
    }
}
