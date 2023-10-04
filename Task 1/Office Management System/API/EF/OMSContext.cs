using API.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace API.EF
{
    public class OMSContext:DbContext
    {
        public OMSContext(DbContextOptions<OMSContext> options):base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Admin)
                .WithMany(a => a.Employees)
                .HasForeignKey(e => e.AdminId)
                .IsRequired();
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
