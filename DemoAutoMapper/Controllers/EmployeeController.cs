using AutoMapper;
using DemoAutoMapper.Models;
using DemoAutoMapper.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace DemoAutoMapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IEnumerable<Employee> _employees = new List<Employee>
            {
                new Employee {Id = 1, FirstName = "Sakib", LastName = "Khan", Email = "sakib@gmail.com", Gender = "male" },
                new Employee {Id = 2, FirstName = "Ratna", LastName = "Khatun", Email = "ratan@gmail.com", Gender = "female"}
            };

        public EmployeeController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public EmployeeModel Get(int id)
        {
            Employee? employee = getEmployeeById(id);
            var empModel = _mapper.Map<EmployeeModel>(employee);
            return empModel;
        }

        private IEnumerable<Employee?> getEmployees()
        {
            return _employees;
        }

        private Employee? getEmployeeById(int id)
        {
            return _employees.Where(emp => emp.Id == id).FirstOrDefault();
        }
    }
}
