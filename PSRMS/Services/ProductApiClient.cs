using System.Net.Http.Json;
using PSRMS.Models;
namespace PSRMS.Services
{
    public class ProductApiClient
    {
        private readonly HttpClient _httpClient;
        public ProductApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<HttpResponseMessage> ProductAsync(ProductRequests product)
        {
            return await _httpClient.PostAsJsonAsync("api/Manufacturer/product",product);
        }
    }
}