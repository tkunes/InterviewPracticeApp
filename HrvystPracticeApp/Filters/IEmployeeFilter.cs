using HrvystPracticeApp.Models;

namespace HrvystPracticeApp.Filters
{
    public interface IEmployeeFilter
    {
        List<Employee> FilterEmployees(List<Employee> unfilteredEmployees, string? FirstNameFilter, string? LastNameFilter);
        bool FirstNameMatch(string FirstName, string? FirstNameFilter);

        bool LastNameMatch(string LastName, string? LastNameFilter);
    }
}
