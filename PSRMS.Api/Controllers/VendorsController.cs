using Microsoft.AspNetCore.Mvc;
using PSRMS.Models;
using PSRMS.Api.Data;

namespace PSRMS.Api.Controllers
{
    [ApiController]
    [Route("api/vendors")]
    public class VendorsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public VendorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public async Task<ActionResult> Create(RegisterRequests requests)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Registers.Add(requests);

            await _context.SaveChangesAsync();

            return Ok(requests);
        }
    }
}