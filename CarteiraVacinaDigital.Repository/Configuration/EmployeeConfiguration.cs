using CarteiraVacinaDigital.Model.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarteiraVacinaDigital.Repository.Configuration
{
    class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(f => f.Id);

            builder
                .Property(f => f.Name)
                .IsRequired();

            builder
                .Property(f => f.Email)
                .IsRequired();

            builder
                .Property(f => f.Password)
                .IsRequired();

            builder
                .Property(f => f.Cpf)
                .IsRequired();

            builder
                .Property(f => f.Coren)
                .IsRequired();

            builder
                .Property(f => f.Adress);

            builder
                .Property(f => f.City);

            builder
                .Property(f => f.State);

            builder
                .Property(f => f.Cep);

            builder
                .Property(f => f.Office);
        }
    }
}
