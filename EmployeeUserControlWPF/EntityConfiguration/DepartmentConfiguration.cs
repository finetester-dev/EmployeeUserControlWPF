using EmployeeUserControlWPF.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeUserControlWPF.EntityConfiguration
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<DepartmentModel>
    {
        public void Configure(EntityTypeBuilder<DepartmentModel> builder)
        {
            builder.ToTable("Department", "dbo");
            builder.HasKey(x => x.DepartmentId);
            builder.Property(x => x.Name);
        }
    }
}