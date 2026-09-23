using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PSRMS.Models;
using PSRMS.Services;
namespace PSRMS.Pages.Manufacturer;

public class ProductModel : PageModel
{
    private readonly ProductApiClient _productApiClient;
    public ProductModel(ProductApiClient productApiClient)
    {
        _productApiClient = productApiClient;
    }
    [BindProperty]
    public ProductRequests product {get; set;} = new ProductRequests();
    public string Message {get; set;}=string.Empty;
    public void OnGet()
    {
        
    }
    public async Task<IActionResult> OnPostAsync()
    {
        var response = await _productApiClient.ProductAsync(product);
        if (response.IsSuccessStatusCode)
        {
            return RedirectToPage("/Manufacturer/Product");
        }
        Message = "Failed to Save product";
        return Page();
    }
}