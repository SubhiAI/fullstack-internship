using EmployeeManagement.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.API.Data
{
    public class App_DbContext : DbContext
    {
        public App_DbContext(DbContextOptions<App_DbContext> options) : base(options)
        {

        }

        public DbSet<Employee> employee_data { get; set; }

        public DbSet<Department> department { get; set; }
        public DbSet<JobPosition> jobposition { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().ToTable("department");
        }
    }
}
