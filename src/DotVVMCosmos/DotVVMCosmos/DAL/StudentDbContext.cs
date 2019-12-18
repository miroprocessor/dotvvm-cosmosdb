using Microsoft.EntityFrameworkCore;
using DotVVMCosmos.DAL.Entities;
namespace DotVVMCosmos.DAL
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        //    optionsBuilder.UseCosmos(Configuration.GetValue<string>("EndPoint"),
        //                Configuration.GetValue<string>("Cosmoskey"),
        //                databaseName: Configuration.GetValue<string>("DatabaseName"));
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultContainer("Students");

            modelBuilder.Entity<Student>().ToContainer("Students");
        }
    }
}
