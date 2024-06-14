using EmployeeUserControlWPF.Model;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Reflection;

namespace EmployeeUserControlWPF.DataAccess
{
    public class ApplicationDataContext : DbContext
    {
        public DbSet<EmployeeModel> employees { get; set; }

        public DbSet<DepartmentModel> departments { get; set; }

        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> optionsBuilder) : base(optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
