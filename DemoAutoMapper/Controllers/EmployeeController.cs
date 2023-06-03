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
                new Employee {Id = 1, FirstName = "Sakib", LastName = "Khan", Email = "sakib@gmail.com", Gender = "male", Department = new Department {Id = 2, Name = "IT"} },
                new Employee {Id = 2, FirstName = "Ratna", LastName = "Khatun", Email = "ratan@gmail.com", Gender = "female" , Department = new Department {Id = 1, Name = "HR"} }
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

        [Route("GetEmployees")]
        [HttpGet]
        public IEnumerable<EmployeeModel> Get()
        {
            IEnumerable<Employee?> employees = getEmployees();
            var empModel = _mapper.Map<List<EmployeeModel>>(employees);
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
