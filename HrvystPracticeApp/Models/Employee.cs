using Newtonsoft.Json;

namespace HrvystPracticeApp.Models
{
    public class Employee
    {
        public required string FirstName { get; set; }

        public required string LastName { get; set; }

        public string? Email { get; set; }

        public int? EmployeeNumber { get; set; }
    }
}
