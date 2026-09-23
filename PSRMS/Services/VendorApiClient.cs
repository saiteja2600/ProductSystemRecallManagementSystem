using System.Net.Http.Json;
using PSRMS.Models;

namespace PSRMS.Services
{
    public class VendorApiClient
    {
        private readonly HttpClient _httpClient;

        public VendorApiClient(HttpClient httpClient)
        {
            _httpClient=httpClient;
        }
        public async Task<HttpResponseMessage> RegisterAsync(RegisterRequests vendor)
        {
            return await _httpClient.PostAsJsonAsync("api/Employee/Register",vendor);
        }
    }
}