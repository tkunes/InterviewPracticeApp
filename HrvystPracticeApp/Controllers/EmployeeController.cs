using HrvystPracticeApp.Models;
using HrvystPracticeApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace HrvystPracticeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]   
        public async Task<IEnumerable<Employee>> GetAsync(string? FirstName, string? LastName)
        {
            List<Employee> list = await _employeeService.GetEmployee(FirstName, LastName);

            return list;
        }
    }
}
