using Microsoft.AspNetCore.Mvc;
using PSRMS.Models;

namespace PSRMS.Api.Controllers
{
    [ApiController]
    [Route("api/Product")]
    public class ProductController : ControllerBase
    {
        private static readonly List<ProductRequests> products = new();

        [HttpPost("create")]
        public IActionResult CreateProduct([FromBody] ProductRequests product)
        {
            products.Add(product);

            return Ok(new
            {
                message = "Product created successfully.",
                product
            });
        }

        [HttpGet("products")]
        public IActionResult GetProducts()
        {
            return Ok(products);
        }
    }
}