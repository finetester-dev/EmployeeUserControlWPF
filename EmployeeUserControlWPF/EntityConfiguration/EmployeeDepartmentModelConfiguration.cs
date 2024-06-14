using EmployeeUserControlWPF.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeUserControlWPF.EntityConfiguration
{
    public class EmployeeDepartmentModelConfiguration : IEntityTypeConfiguration<EmployeeDepartmentModel>
    {
        public void Configure(EntityTypeBuilder<EmployeeDepartmentModel> builder)
        {
            builder.ToTable("EmployeeDepartment");
            builder.HasKey(x => x.EmployeeDepartmentId);
            builder.Property(x => x.EmployeeId);
            builder.Property(x => x.DepartmentId);
            builder.HasOne(x => x.Employee).WithMany(x => x.Departments).HasForeignKey(x => x.EmployeeId);
            builder.HasOne(x => x.Department).WithMany(x => x.Employees).HasForeignKey(x => x.DepartmentId);
        }
    }
}
