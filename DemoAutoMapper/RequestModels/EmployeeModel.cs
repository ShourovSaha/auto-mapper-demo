using DemoAutoMapper.Models;
using System.ComponentModel;
using System.Reflection;

namespace DemoAutoMapper.RequestModels
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        [DisplayName("Departmant Name")]
        public string DepartmentName { get; set; }
    }
}
