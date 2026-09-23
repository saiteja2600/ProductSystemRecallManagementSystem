using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
var apiBaseUrl = "http://localhost:5075/";

builder.Services.AddHttpClient<PSRMS.Services.VendorApiClient>("PSRMSApi",client =>
{
    client.BaseAddress = new Uri(apiBaseUrl);
});

builder.Services.AddHttpClient<PSRMS.Services.EmployeeApiClient>("PSRMSApi",client =>
{
    client.BaseAddress = new Uri(apiBaseUrl);
});

builder.Services.AddHttpClient<PSRMS.Services.ProductApiClient>("PSRMSApi",client =>
{
    client.BaseAddress = new Uri(apiBaseUrl);
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

// Routers

// app.MapGet("/StaffLogin", () => Results.Redirect("/Accounts/Login"));
// app.MapGet("/StaffRegister",()=>Results.Redirect("/Accounts/Register"));
// app.MapGet("/Dashboard",()=>Results.Redirect("/Manufacturer/Dashboard"));

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
