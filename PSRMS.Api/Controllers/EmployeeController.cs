using Microsoft.AspNetCore.Mvc;
using PSRMS.Models;

namespace PSRMS.Api.Controllers
{
    [ApiController]
    [Route("api/Employee")]
    public class EmployeeController : ControllerBase
    {
        private static List<EmployeeRequests> employees =
            new List<EmployeeRequests>();

        // POST
        [HttpPost("employee")]
        public IActionResult Employee([FromBody] EmployeeRequests employee)
        {
            employees.Add(employee);

            return Ok(new
            {
                message = "Employee received",
                employee
            });
        }

        // GET
        [HttpGet("employees")]
        public IActionResult GetEmployees()
        {
            return Ok(employees);
        }
    }
}