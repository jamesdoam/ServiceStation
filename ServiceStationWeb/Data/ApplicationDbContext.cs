using Microsoft.EntityFrameworkCore;
using ServiceStationWeb.Models;

namespace ServiceStationWeb.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {                           
        }

        public DbSet<Ticket> Tickets { get; set; }
    }
}
