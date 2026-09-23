using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PSRMS.Models;

namespace PSRMS.Pages.Accounts;

public class RegisterModel : PageModel
{
    [BindProperty]
    public RegisterRequests Vendor { get; set; } = new RegisterRequests();

    public string Message { get; set; } = string.Empty;

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        Message = Vendor.CompanyName;

        const string contactPattern =
            @"^(?:(?:\+91|91|0)[\s-]?)?[6-9]\d{9}$";

        if (Vendor.Password != Vendor.ConfirmPassword)
        {
            ModelState.AddModelError(
                "Vendor.ConfirmPassword",
                "Password did not match"
            );
        }

        if (!string.IsNullOrWhiteSpace(Vendor.ContactNumber) &&
            !Regex.IsMatch(
                Vendor.ContactNumber.Trim(),
                contactPattern))
        {
            ModelState.AddModelError(
                "Vendor.ContactNumber",
                "Enter a valid Indian mobile number."
            );
        }

        if (!ModelState.IsValid)
        {
            return Page();
        }
        Console.WriteLine("Company Name: "+Vendor.CompanyName);

        return RedirectToPage("/Accounts/Login");
    }
}