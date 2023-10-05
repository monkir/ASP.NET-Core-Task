using DAL.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.EF
{
    public class OMSContext:DbContext
    {
        //public OMSContext(DbContextOptions<OMSContext> options):base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost; port=3306; database=OMS;user=root;password=tiger");
            //optionsBuilder.UseSqlServer("server=MONKIR\\SQLEXPRESS; initial catalog=Office Management System; integrated security=true; TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Admin>()
                .HasKey(a => a.Id);
            modelBuilder.Entity<Employee>()
                .HasKey(e => e.Id);*/
            /*modelBuilder.Entity<Employee>()
                .HasOne(e => e.Admin)
                .WithMany(a => a.Employees)
                .HasForeignKey(e => e.AdminId)
                .IsRequired();*/
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
