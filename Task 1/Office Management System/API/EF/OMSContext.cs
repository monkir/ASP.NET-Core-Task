using API.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace API.EF
{
    public class OMSContext:DbContext
    {
        public OMSContext(DbContextOptions<OMSContext> options):base(options) { }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
