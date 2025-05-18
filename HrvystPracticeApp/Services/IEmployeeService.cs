using HrvystPracticeApp.Models;

namespace HrvystPracticeApp.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployee(string? firstNameFilter, string? lastNameFilter);
    }
}
