using EmployeeUserControlWPF.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeUserControlWPF.EntityConfiguration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<EmployeeModel>
    {
        public void Configure(EntityTypeBuilder<EmployeeModel> builder)
        {
            builder.ToTable("Employee");
            builder.HasKey(x => x.EmployeeId);
            builder.Property(x => x.Name);
            builder.Property(x => x.DOB);
            builder.Property(x => x.Salary);
        }
    }
}