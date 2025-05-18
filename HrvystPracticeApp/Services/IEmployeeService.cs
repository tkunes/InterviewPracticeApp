using HrvystPracticeApp.Models;

namespace HrvystPracticeApp.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployee(string? firstNameFilter, string? lastNameFilter);
    }
}
