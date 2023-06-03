using DemoAutoMapper.Models;
using System.Reflection;

namespace DemoAutoMapper.RequestModels
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
    }
}
