﻿using HrvystPracticeApp.Filters;
using HrvystPracticeApp.Models;
using Newtonsoft.Json;

namespace HrvystPracticeApp.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeFilter _employeeFilter;
        public EmployeeService(IEmployeeFilter employeeFilter) 
        {
            _employeeFilter = employeeFilter;
        }

        public async Task<List<Employee>> GetEmployee(string? firstName, string? lastName)
        {
            var jsonString = await getJSONStringFromGoogle();

            List<Employee>? employees = (JsonConvert.DeserializeObject<IEnumerable<Employee>>(jsonString) as List<Employee>);

            if (employees == null)
            {
                throw new Exception("No records found");
            }

            return _employeeFilter.FilterEmployees(employees, firstName, lastName);
        }

        public async Task<string> getJSONStringFromGoogle()
        {
            var url = "https://drive.usercontent.google.com/u/0/uc?id=1UQwIdAJuRsvQqPJzkHkUOKPS3Fs_JhlD&export=download";

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    return content;
                }
            }

            throw new Exception("Unable to retreive JSON file");
        }


    }
}

