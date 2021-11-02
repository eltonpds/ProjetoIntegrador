using CarteiraVacinaDigital.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarteiraVacinaDigital.Repository.Configuration
{
    public class EmployeeLogConfiguration : IEntityTypeConfiguration<EmployeeLog>
    {
        public void Configure(EntityTypeBuilder<EmployeeLog> builder)
        {
            builder.HasKey(el => el.Id);

            builder
                .Property(el => el.Information);

            builder
                .Property(el => el.Action)
                .IsRequired();

            builder
                .Property(el => el.DateTime)
                .IsRequired();
        }
    }
}
