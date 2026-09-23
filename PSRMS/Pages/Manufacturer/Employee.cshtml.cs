using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PSRMS.Models;
using PSRMS.Services;

namespace PSRMS.Pages.Manufactors;

public class EmployeeModel : PageModel
{
    private readonly EmployeeApiClient _employeeApiClient;

    public EmployeeModel(EmployeeApiClient employeeApiClient)
    {
        _employeeApiClient = employeeApiClient;
    }

    [BindProperty]
    public EmployeeRequests employee { get; set; } = new EmployeeRequests();

    public string Message { get; set; } = string.Empty;

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPostAsync()
    {
        Console.WriteLine($"Employee Name: {employee.FullName}");

        var response = await _employeeApiClient.EmployeeAsync(employee);

        if (response.IsSuccessStatusCode)
        {
            return RedirectToPage("/Manufacturer/Employee");
        }

        Message = "Failed to save employee.";

        return Page();
    }
}