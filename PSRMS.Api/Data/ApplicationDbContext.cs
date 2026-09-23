using Microsoft.EntityFrameworkCore;
using PSRMS.Models;
// using Microsoft.EntityFrameworkCore.Sqlite;
namespace PSRMS.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (
            DbContextOptions<ApplicationDbContext> options
        ): base(options)
        {
            
        }

        public DbSet<RegisterRequests> Registers {get; set;}
    }
}