﻿using System.Reflection;

namespace DemoAutoMapper.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public Department Department { get; set; }
        public string GetFullName()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}
