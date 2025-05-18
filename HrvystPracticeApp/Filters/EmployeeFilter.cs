using HrvystPracticeApp.Models;

namespace HrvystPracticeApp.Filters
{
    public class EmployeeFilter : IEmployeeFilter
    {

        public List<Employee> FilterEmployees(List<Employee> unfilteredEmployees, string? FirstNameFilter, string? LastNameFilter)
        {
            if (String.IsNullOrEmpty(FirstNameFilter) && String.IsNullOrEmpty(LastNameFilter))
            {
                // no filtering needed - return all employees
                return unfilteredEmployees;
            }

            List<Employee> filteredEmployees = new List<Employee>();

            foreach (var value in unfilteredEmployees)
            {
                if (FirstNameMatch(value.FirstName, FirstNameFilter)) { filteredEmployees.Add(value); }

                if (LastNameMatch(value.LastName, LastNameFilter)) { filteredEmployees.Add(value); }

            }

            return filteredEmployees;
        }

        public bool FirstNameMatch(string FirstName, string? FirstNameFilter)
        {
            if(!string.IsNullOrEmpty(FirstNameFilter) && FirstName.Contains(FirstNameFilter))
            {
                return true;
            }

            return false;
        }

        public bool LastNameMatch(string LastName, string? LastNameFilter)
        {
            if (!string.IsNullOrEmpty(LastNameFilter) && LastName.Contains(LastNameFilter))
            {
                return true;
            }

            return false;
        }
    }
}
