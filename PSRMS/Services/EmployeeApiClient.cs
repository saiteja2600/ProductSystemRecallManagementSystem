using System.Net.Http.Json;
using PSRMS.Models;
namespace PSRMS.Services
{
    public class EmployeeApiClient
    {
        private readonly HttpClient _httpClient;
        public EmployeeApiClient(HttpClient httpClient)
        {
            _httpClient=httpClient;
        }
        public async Task<HttpResponseMessage> EmployeeAsync(EmployeeRequests employee)
        {
            return await _httpClient.PostAsJsonAsync("api/Employee/Employee",employee);
        }
    }
}